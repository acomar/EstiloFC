using Domain.Entities;
using System.Data.Entity.Migrations;
using Repository.Contexts;
using System;

namespace Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppContext context)
        {
            //SeedCategories(context);
            SeedProducts(context);
            //SeedStock(context);
            //SeedGender(context);
            //SeedPaymentType(context);
            //SeedSize(context);
            //SeedContactForm(context);
            //SeedColors(context);
            //SeedStates(context);
            //SeedCities(context);
            //SeedOrderStatus(context);
            //SeedRattingType(context);
            //SeedPromoCode(context);
        }

        private void SeedPromoCode(AppContext context)
        {
            context.PromoCodes.AddOrUpdate(
              c => c.Id,
              new PromoCode { Id = 1, Code = "VIP10ESTILOFC", CreatedDate= DateTime.Now, ExpirationDate = DateTime.Now.AddDays(7), PromoType = PromoTypeEnum.Percent, Value=10}
              );
        }

        private void SeedOrderStatus(AppContext context)
        {
            context.OrderStatus.AddOrUpdate(
                 c => c.Id,
                 new OrderStatus { Id = 1, Key = "AGUARDANDO_PAGAMENTO", Description = "Aguardando pagto.", Definition = "o comprador iniciou a transação, mas até o momento o PagSeguro não recebeu nenhuma informação sobre o pagamento." },
                 new OrderStatus { Id = 2, Key = "EM_ANALISE", Description = "Em análise", Definition = "O comprador optou por pagar com um cartão de crédito e o PagSeguro está analisando o risco da transação." },
                 new OrderStatus { Id = 3, Key = "PAGA", Description = "Paga", Definition = "A transação foi paga pelo comprador e o PagSeguro já recebeu uma confirmação da instituição financeira responsável pelo processamento." },
                 new OrderStatus { Id = 4, Key = "DISPONÍVEL", Description = "Disponivel", Definition = "A transação foi paga e chegou ao final de seu prazo de liberação sem ter sido retornada e sem que haja nenhuma disputa aberta." },
                 new OrderStatus { Id = 5, Key = "EM_DISPUTA", Description = "Em disputa", Definition = "O comprador, dentro do prazo de liberação da transação, abriu uma disputa." },
                 new OrderStatus { Id = 6, Key = "DEVOLVIDA", Description = "Devolvida", Definition = "O valor da transação foi devolvido para o comprador." },
                 new OrderStatus { Id = 7, Key = "CANCELADA", Description = "Cancelada", Definition = "A transação foi cancelada sem ter sido finalizada." },
                 new OrderStatus { Id = 8, Key = "CHARGEBACK_DEBITADO", Description = "Chargeback debitado", Definition = "O valor da transação foi devolvido para o comprador." },
                 new OrderStatus { Id = 9, Key = "EM_CONTESTACAO", Description = "Em contestação", Definition = "O comprador abriu uma solicitação de chargeback junto à operadora do cartão de crédito." }
                 );
        }
        private void SeedStates(AppContext context)
        {
            context.States.AddOrUpdate(c => c.Id, new State { Id = 1, Name = "Acre", Uf = "AC" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 2, Name = "Alagoas", Uf = "AL" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 3, Name = "Amazonas", Uf = "AM" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 4, Name = "Amapá", Uf = "AP" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 5, Name = "Bahia", Uf = "BA" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 6, Name = "Ceará", Uf = "CE" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 7, Name = "Distrito Federal", Uf = "DF" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 8, Name = "Espírito Santo", Uf = "ES" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 9, Name = "Goiás", Uf = "GO" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 10, Name = "Maranhão", Uf = "MA" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 11, Name = "Minas Gerais", Uf = "MG" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 12, Name = "Mato Grosso do Sul", Uf = "MS" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 13, Name = "Mato Grosso", Uf = "MT" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 14, Name = "Pará", Uf = "PA" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 15, Name = "Paraíba", Uf = "PB" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 16, Name = "Pernambuco", Uf = "PE" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 17, Name = "Piauí", Uf = "PI" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 18, Name = "Paraná", Uf = "PR" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 19, Name = "Rio de Janeiro", Uf = "RJ" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 20, Name = "Rio Grande do Norte", Uf = "RN" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 21, Name = "Rondônia", Uf = "RO" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 22, Name = "Roraima", Uf = "RR" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 23, Name = "Rio Grande do Sul", Uf = "RS" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 24, Name = "Santa Catarina", Uf = "SC" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 25, Name = "Sergipe", Uf = "SE" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 26, Name = "São Paulo", Uf = "SP" });
            context.States.AddOrUpdate(c => c.Id, new State { Id = 27, Name = "Tocantins", Uf = "TO" });
        }
        private void SeedCities(AppContext context)
        {
            Cities1(context);
            Cities2(context);
            Cities3(context);
            Cities4(context);
            Cities5(context);
            Cities6(context);
            Cities7(context);
            Cities8(context);
            Cities9(context);
            Cities10(context);
            Cities11(context);
            Cities12(context);
            Cities13(context);
            Cities14(context);
            Cities15(context);
            Cities16(context);
            Cities17(context);
            Cities18(context);
            Cities19(context);
            Cities20(context);
            Cities21(context);
            Cities22(context);
            Cities23(context);
            Cities24(context);
            Cities25(context);
            Cities26(context);
            Cities27(context);
        }

        private static void Cities1(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 79, Name = "Acrelândia", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 80, Name = "Assis Brasil", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 81, Name = "Brasiléia", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 82, Name = "Bujari", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 83, Name = "Capixaba", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 84, Name = "Cruzeiro do Sul", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 85, Name = "Epitaciolândia", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 86, Name = "Feijó", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 87, Name = "Jordão", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 88, Name = "Mâncio Lima", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 89, Name = "Manoel Urbano", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 90, Name = "Marechal Thaumaturgo", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 91, Name = "Plácido de Castro", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 92, Name = "Porto Acre", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 93, Name = "Porto Walter", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 94, Name = "Rio Branco", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 95, Name = "Rodrigues Alves", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 96, Name = "Santa Rosa do Purus", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 97, Name = "Sena Madureira", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 98, Name = "Senador Guiomard", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 99, Name = "Tarauacá", IdState = 1 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 100, Name = "Xapuri", IdState = 1 });
        }
        private static void Cities2(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 101, Name = "Água Branca", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 102, Name = "Anadia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 103, Name = "Arapiraca", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 104, Name = "Atalaia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 105, Name = "Barra de Santo Antônio", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 106, Name = "Barra de São Miguel", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 107, Name = "Batalha", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 108, Name = "Belém", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 109, Name = "Belo Monte", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 110, Name = "Boca da Mata", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 111, Name = "Branquinha", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 112, Name = "Cacimbinhas", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 113, Name = "Cajueiro", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 114, Name = "Campestre", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 115, Name = "Campo Alegre", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 116, Name = "Campo Grande", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 117, Name = "Canapi", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 118, Name = "Capela", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 119, Name = "Carneiros", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 120, Name = "Chã Preta", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 121, Name = "Coité do Nóia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 122, Name = "Colônia Leopoldina", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 123, Name = "Coqueiro Seco", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 124, Name = "Coruripe", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 125, Name = "Craíbas", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 126, Name = "Delmiro Gouveia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 127, Name = "Dois Riachos", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 128, Name = "Estrela de Alagoas", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 129, Name = "Feira Grande", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 130, Name = "Feliz Deserto", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 131, Name = "Flexeiras", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 132, Name = "Girau do Ponciano", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 133, Name = "Ibateguara", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 134, Name = "Igaci", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 135, Name = "Igreja Nova", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 136, Name = "Inhapi", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 137, Name = "Jacaré dos Homens", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 138, Name = "Jacuípe", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 139, Name = "Japaratinga", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 140, Name = "Jaramataia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 141, Name = "Jequiá da Praia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 142, Name = "Joaquim Gomes", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 143, Name = "Jundiá", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 144, Name = "Junqueiro", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 145, Name = "Lagoa da Canoa", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 146, Name = "Limoeiro de Anadia", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 147, Name = "Maceió", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 148, Name = "Major Isidoro", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 149, Name = "Mar Vermelho", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 150, Name = "Maragogi", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 151, Name = "Maravilha", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 152, Name = "Marechal Deodoro", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 153, Name = "Maribondo", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 154, Name = "Mata Grande", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 155, Name = "Matriz de Camaragibe", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 156, Name = "Messias", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 157, Name = "Minador do Negrão", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 158, Name = "Monteirópolis", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 159, Name = "Murici", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 160, Name = "Novo Lino", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 161, Name = "Olho d`Água das Flores", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 162, Name = "Olho d`Água do Casado", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 163, Name = "Olho d`Água Grande", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 164, Name = "Olivença", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 165, Name = "Ouro Branco", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 166, Name = "Palestina", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 167, Name = "Palmeira dos Índios", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 168, Name = "Pão de Açúcar", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 169, Name = "Pariconha", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 170, Name = "Paripueira", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 171, Name = "Passo de Camaragibe", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 172, Name = "Paulo Jacinto", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 173, Name = "Penedo", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 174, Name = "Piaçabuçu", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 175, Name = "Pilar", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 176, Name = "Pindoba", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 177, Name = "Piranhas", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 178, Name = "Poço das Trincheiras", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 179, Name = "Porto Calvo", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 180, Name = "Porto de Pedras", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 181, Name = "Porto Real do Colégio", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 182, Name = "Quebrangulo", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 183, Name = "Rio Largo", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 184, Name = "Roteiro", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 185, Name = "Santa Luzia do Norte", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 186, Name = "Santana do Ipanema", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 187, Name = "Santana do Mundaú", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 188, Name = "São Brás", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 189, Name = "São José da Laje", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 190, Name = "São José da Tapera", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 191, Name = "São Luís do Quitunde", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 192, Name = "São Miguel dos Campos", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 193, Name = "São Miguel dos Milagres", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 194, Name = "São Sebastião", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 195, Name = "Satuba", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 196, Name = "Senador Rui Palmeira", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 197, Name = "Tanque d`Arca", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 198, Name = "Taquarana", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 199, Name = "Teotônio Vilela", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 200, Name = "Traipu", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 201, Name = "União dos Palmares", IdState = 2 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 202, Name = "Viçosa", IdState = 2 });
        }
        private static void Cities3(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 219, Name = "Alvarães", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 220, Name = "Amaturá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 221, Name = "Anamã", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 222, Name = "Anori", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 223, Name = "Apuí", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 224, Name = "Atalaia do Norte", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 225, Name = "Autazes", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 226, Name = "Barcelos", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 227, Name = "Barreirinha", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 228, Name = "Benjamin Constant", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 229, Name = "Beruri", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 230, Name = "Boa Vista do Ramos", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 231, Name = "Boca do Acre", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 232, Name = "Borba", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 233, Name = "Caapiranga", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 234, Name = "Canutama", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 235, Name = "Carauari", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 236, Name = "Careiro", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 237, Name = "Careiro da Várzea", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 238, Name = "Coari", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 239, Name = "Codajás", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 240, Name = "Eirunepé", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 241, Name = "Envira", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 242, Name = "Fonte Boa", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 243, Name = "Guajará", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 244, Name = "Humaitá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 245, Name = "Ipixuna", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 246, Name = "Iranduba", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 247, Name = "Itacoatiara", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 248, Name = "Itamarati", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 249, Name = "Itapiranga", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 250, Name = "Japurá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 251, Name = "Juruá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 252, Name = "Jutaí", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 253, Name = "Lábrea", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 254, Name = "Manacapuru", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 255, Name = "Manaquiri", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 256, Name = "Manaus", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 257, Name = "Manicoré", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 258, Name = "Maraã", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 259, Name = "Maués", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 260, Name = "Nhamundá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 261, Name = "Nova Olinda do Norte", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 262, Name = "Novo Airão", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 263, Name = "Novo Aripuanã", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 264, Name = "Parintins", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 265, Name = "Pauini", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 266, Name = "Presidente Figueiredo", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 267, Name = "Rio Preto da Eva", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 268, Name = "Santa Isabel do Rio Negro", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 269, Name = "Santo Antônio do Içá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 270, Name = "São Gabriel da Cachoeira", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 271, Name = "São Paulo de Olivença", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 272, Name = "São Sebastião do Uatumã", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 273, Name = "Silves", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 274, Name = "Tabatinga", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 275, Name = "Tapauá", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 276, Name = "Tefé", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 277, Name = "Tonantins", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 278, Name = "Uarini", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 279, Name = "Urucará", IdState = 3 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 280, Name = "Urucurituba", IdState = 3 });
        }
        private static void Cities4(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 203, Name = "Amapá", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 204, Name = "Calçoene", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 205, Name = "Cutias", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 206, Name = "Ferreira Gomes", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 207, Name = "Itaubal", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 208, Name = "Laranjal do Jari", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 209, Name = "Macapá", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 210, Name = "Mazagão", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 211, Name = "Oiapoque", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 212, Name = "Pedra Branca do Amaparí", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 213, Name = "Porto Grande", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 214, Name = "Pracuúba", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 215, Name = "Santana", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 216, Name = "Serra do Navio", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 217, Name = "Tartarugalzinho", IdState = 4 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 218, Name = "Vitória do Jari", IdState = 4 });
        }
        private static void Cities5(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 281, Name = "Abaíra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 282, Name = "Abaré", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 283, Name = "Acajutiba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 284, Name = "Adustina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 285, Name = "Água Fria", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 286, Name = "Aiquara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 287, Name = "Alagoinhas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 288, Name = "Alcobaça", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 289, Name = "Almadina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 290, Name = "Amargosa", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 291, Name = "Amélia Rodrigues", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 292, Name = "América Dourada", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 293, Name = "Anagé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 294, Name = "Andaraí", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 295, Name = "Andorinha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 296, Name = "Angical", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 297, Name = "Anguera", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 298, Name = "Antas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 299, Name = "Antônio Cardoso", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 300, Name = "Antônio Gonçalves", IdState = 5 });

            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 301, Name = "Aporá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 302, Name = "Apuarema", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 303, Name = "Araças", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 304, Name = "Aracatu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 305, Name = "Araci", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 306, Name = "Aramari", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 307, Name = "Arataca", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 308, Name = "Aratuípe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 309, Name = "Aurelino Leal", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 310, Name = "Baianópolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 311, Name = "Baixa Grande", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 312, Name = "Banzaê", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 313, Name = "Barra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 314, Name = "Barra da Estiva", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 315, Name = "Barra do Choça", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 316, Name = "Barra do Mendes", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 317, Name = "Barra do Rocha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 318, Name = "Barreiras", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 319, Name = "Barro Alto", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 320, Name = "Barro Preto antigo Gov. Lomanto Jr.", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 321, Name = "Barrocas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 322, Name = "Belmonte", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 323, Name = "Belo Campo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 324, Name = "Biritinga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 325, Name = "Boa Nova", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 326, Name = "Boa Vista do Tupim", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 327, Name = "Bom Jesus da Lapa", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 328, Name = "Bom Jesus da Serra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 329, Name = "Boninal", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 330, Name = "Bonito", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 331, Name = "Boquira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 332, Name = "Botuporã", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 333, Name = "Brejões", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 334, Name = "Brejolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 335, Name = "Brotas de Macaúbas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 336, Name = "Brumado", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 337, Name = "Buerarema", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 338, Name = "Buritirama", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 339, Name = "Caatiba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 340, Name = "Cabaceiras do Paraguaçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 341, Name = "Cachoeira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 342, Name = "Caculé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 343, Name = "Caém", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 344, Name = "Caetanos", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 345, Name = "Caetité", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 346, Name = "Cafarnaum", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 347, Name = "Cairu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 348, Name = "Caldeirão Grande", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 349, Name = "Camacan", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 350, Name = "Camaçari", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 351, Name = "Camamu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 352, Name = "Campo Alegre de Lourdes", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 353, Name = "Campo Formoso", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 354, Name = "Canápolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 355, Name = "Canarana", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 356, Name = "Canavieiras", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 357, Name = "Candeal", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 358, Name = "Candeias", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 359, Name = "Candiba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 360, Name = "Cândido Sales", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 361, Name = "Cansanção", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 362, Name = "Canudos", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 363, Name = "Capela do Alto Alegre", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 364, Name = "Capim Grosso", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 365, Name = "Caraíbas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 366, Name = "Caravelas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 367, Name = "Cardeal da Silva", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 368, Name = "Carinhanha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 369, Name = "Casa Nova", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 370, Name = "Castro Alves", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 371, Name = "Catolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 372, Name = "Catu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 373, Name = "Caturama", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 374, Name = "Central", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 375, Name = "Chorrochó", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 376, Name = "Cícero Dantas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 377, Name = "Cipó", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 378, Name = "Coaraci", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 379, Name = "Cocos", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 380, Name = "Conceição da Feira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 381, Name = "Conceição do Almeida", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 382, Name = "Conceição do Coité", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 383, Name = "Conceição do Jacuípe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 384, Name = "Conde", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 385, Name = "Condeúba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 386, Name = "Contendas do Sincorá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 387, Name = "Coração de Maria", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 388, Name = "Cordeiros", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 389, Name = "Coribe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 390, Name = "Coronel João Sá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 391, Name = "Correntina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 392, Name = "Cotegipe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 393, Name = "Cravolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 394, Name = "Crisópolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 395, Name = "Cristópolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 396, Name = "Cruz das Almas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 397, Name = "Curaçá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 398, Name = "Dário Meira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 399, Name = "Dias d`Ávila", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 400, Name = "Dom Basílio", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 401, Name = "Dom Macedo Costa", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 402, Name = "Elísio Medrado", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 403, Name = "Encruzilhada", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 404, Name = "Entre Rios", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 405, Name = "Érico Cardoso", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 406, Name = "Esplanada", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 407, Name = "Euclides da Cunha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 408, Name = "Eunápolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 409, Name = "Fátima", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 410, Name = "Feira da Mata", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 411, Name = "Feira de Santana", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 412, Name = "Filadélfia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 413, Name = "Firmino Alves", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 414, Name = "Floresta Azul", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 415, Name = "Formosa do Rio Preto", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 416, Name = "Gandu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 417, Name = "Gavião", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 418, Name = "Gentio do Ouro", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 419, Name = "Glória", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 420, Name = "Gongogi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 421, Name = "Governador Mangabeira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 422, Name = "Guajeru", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 423, Name = "Guanambi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 424, Name = "Guaratinga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 425, Name = "Heliópolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 426, Name = "Iaçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 427, Name = "Ibiassucê", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 428, Name = "Ibicaraí", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 429, Name = "Ibicoara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 430, Name = "Ibicuí", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 431, Name = "Ibipeba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 432, Name = "Ibipitanga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 433, Name = "Ibiquera", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 434, Name = "Ibirapitanga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 435, Name = "Ibirapuã", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 436, Name = "Ibirataia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 437, Name = "Ibitiara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 438, Name = "Ibititá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 439, Name = "Ibotirama", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 440, Name = "Ichu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 441, Name = "Igaporã", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 442, Name = "Igrapiúna", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 443, Name = "Iguaí", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 444, Name = "Ilhéus", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 445, Name = "Inhambupe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 446, Name = "Ipecaetá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 447, Name = "Ipiaú", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 448, Name = "Ipirá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 449, Name = "Ipupiara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 450, Name = "Irajuba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 451, Name = "Iramaia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 452, Name = "Iraquara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 453, Name = "Irará", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 454, Name = "Irecê", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 455, Name = "Itabela", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 456, Name = "Itaberaba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 457, Name = "Itabuna", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 458, Name = "Itacaré", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 459, Name = "Itaeté", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 460, Name = "Itagi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 461, Name = "Itagibá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 462, Name = "Itagimirim", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 463, Name = "Itaguaçu da Bahia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 464, Name = "Itaju do Colônia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 465, Name = "Itajuípe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 466, Name = "Itamaraju", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 467, Name = "Itamari", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 468, Name = "Itambé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 469, Name = "Itanagra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 470, Name = "Itanhém", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 471, Name = "Itaparica", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 472, Name = "Itapé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 473, Name = "Itapebi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 474, Name = "Itapetinga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 475, Name = "Itapicuru", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 476, Name = "Itapitanga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 477, Name = "Itaquara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 478, Name = "Itarantim", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 479, Name = "Itatim", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 480, Name = "Itiruçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 481, Name = "Itiúba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 482, Name = "Itororó", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 483, Name = "Ituaçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 484, Name = "Ituberá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 485, Name = "Iuiú", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 486, Name = "Jaborandi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 487, Name = "Jacaraci", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 488, Name = "Jacobina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 489, Name = "Jaguaquara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 490, Name = "Jaguarari", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 491, Name = "Jaguaripe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 492, Name = "Jandaíra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 493, Name = "Jequié", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 494, Name = "Jeremoabo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 495, Name = "Jiquiriçá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 496, Name = "Jitaúna", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 497, Name = "João Dourado", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 498, Name = "Juazeiro", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 499, Name = "Jucuruçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 500, Name = "Jussara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 501, Name = "Jussari", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 502, Name = "Jussiape", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 503, Name = "Lafaiete Coutinho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 504, Name = "Lagoa Real", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 505, Name = "Laje", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 506, Name = "Lajedão", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 507, Name = "Lajedinho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 508, Name = "Lajedo do Tabocal", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 509, Name = "Lamarão", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 510, Name = "Lapão", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 511, Name = "Lauro de Freitas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 512, Name = "Lençóis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 513, Name = "Licínio de Almeida", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 514, Name = "Livramento de Nossa Senhora", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 515, Name = "Luís Eduardo Magalhães", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 516, Name = "Macajuba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 517, Name = "Macarani", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 518, Name = "Macaúbas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 519, Name = "Macururé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 520, Name = "Madre de Deus", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 521, Name = "Maetinga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 522, Name = "Maiquinique", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 523, Name = "Mairi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 524, Name = "Malhada", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 525, Name = "Malhada de Pedras", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 526, Name = "Manoel Vitorino", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 527, Name = "Mansidão", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 528, Name = "Maracás", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 529, Name = "Maragogipe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 530, Name = "Maraú", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 531, Name = "Marcionílio Souza", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 532, Name = "Mascote", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 533, Name = "Mata de São João", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 534, Name = "Matina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 535, Name = "Medeiros Neto", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 536, Name = "Miguel Calmon", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 537, Name = "Milagres", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 538, Name = "Mirangaba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 539, Name = "Mirante", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 540, Name = "Monte Santo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 541, Name = "Morpará", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 542, Name = "Morro do Chapéu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 543, Name = "Mortugaba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 544, Name = "Mucugê", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 545, Name = "Mucuri", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 546, Name = "Mulungu do Morro", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 547, Name = "Mundo Novo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 548, Name = "Muniz Ferreira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 549, Name = "Muquém de São Francisco", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 550, Name = "Muritiba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 551, Name = "Mutuípe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 552, Name = "Nazaré", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 553, Name = "Nilo Peçanha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 554, Name = "Nordestina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 555, Name = "Nova Canaã", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 556, Name = "Nova Fátima", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 557, Name = "Nova Ibiá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 558, Name = "Nova Itarana", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 559, Name = "Nova Redenção", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 560, Name = "Nova Soure", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 561, Name = "Nova Viçosa", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 562, Name = "Novo Horizonte", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 563, Name = "Novo Triunfo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 564, Name = "Olindina", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 565, Name = "Oliveira dos Brejinhos", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 566, Name = "Ouriçangas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 567, Name = "Ourolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 568, Name = "Palmas de Monte Alto", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 569, Name = "Palmeiras", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 570, Name = "Paramirim", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 571, Name = "Paratinga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 572, Name = "Paripiranga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 573, Name = "Pau Brasil", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 574, Name = "Paulo Afonso", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 575, Name = "Pé de Serra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 576, Name = "Pedrão", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 577, Name = "Pedro Alexandre", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 578, Name = "Piatã", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 579, Name = "Pilão Arcado", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 580, Name = "Pindaí", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 581, Name = "Pindobaçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 582, Name = "Pintadas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 583, Name = "Piraí do Norte", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 584, Name = "Piripá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 585, Name = "Piritiba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 586, Name = "Planaltino", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 587, Name = "Planalto", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 588, Name = "Poções", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 589, Name = "Pojuca", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 590, Name = "Ponto Novo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 591, Name = "Porto Seguro", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 592, Name = "Potiraguá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 593, Name = "Prado", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 594, Name = "Presidente Dutra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 595, Name = "Presidente Jânio Quadros", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 596, Name = "Presidente Tancredo Neves", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 597, Name = "Queimadas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 598, Name = "Quijingue", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 599, Name = "Quixabeira", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 600, Name = "Rafael Jambeiro", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 601, Name = "Remanso", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 602, Name = "Retirolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 603, Name = "Riachão das Neves", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 604, Name = "Riachão do Jacuípe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 605, Name = "Riacho de Santana", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 606, Name = "Ribeira do Amparo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 607, Name = "Ribeira do Pombal", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 608, Name = "Ribeirão do Largo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 609, Name = "Rio de Contas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 610, Name = "Rio do Antônio", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 611, Name = "Rio do Pires", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 612, Name = "Rio Real", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 613, Name = "Rodelas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 614, Name = "Ruy Barbosa", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 615, Name = "Salinas da Margarida", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 616, Name = "Salvador", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 617, Name = "Santa Bárbara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 618, Name = "Santa Brígida", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 619, Name = "Santa Cruz Cabrália", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 620, Name = "Santa Cruz da Vitória", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 621, Name = "Santa Inês", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 622, Name = "Santa Luzia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 623, Name = "Santa Maria da Vitória", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 624, Name = "Santa Rita de Cássia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 625, Name = "Santa Teresinha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 626, Name = "Santaluz", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 627, Name = "Santana", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 628, Name = "Santanópolis", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 629, Name = "Santo Amaro", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 630, Name = "Santo Antônio de Jesus", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 631, Name = "Santo Estêvão", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 632, Name = "São Desidério", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 633, Name = "São Domingos", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 634, Name = "São Felipe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 635, Name = "São Félix", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 636, Name = "São Félix do Coribe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 637, Name = "São Francisco do Conde", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 638, Name = "São Gabriel", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 639, Name = "São Gonçalo dos Campos", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 640, Name = "São José da Vitória", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 641, Name = "São José do Jacuípe", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 642, Name = "São Miguel das Matas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 643, Name = "São Sebastião do Passé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 644, Name = "Sapeaçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 645, Name = "Sátiro Dias", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 646, Name = "Saubara", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 647, Name = "Saúde", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 648, Name = "Seabra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 649, Name = "Sebastião Laranjeiras", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 650, Name = "Senhor do Bonfim", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 651, Name = "Sento Sé", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 652, Name = "Serra do Ramalho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 653, Name = "Serra Dourada", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 654, Name = "Serra Preta", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 655, Name = "Serrinha", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 656, Name = "Serrolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 657, Name = "Simões Filho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 658, Name = "Sítio do Mato", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 659, Name = "Sítio do Quinto", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 660, Name = "Sobradinho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 661, Name = "Souto Soares", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 662, Name = "Tabocas do Brejo Velho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 663, Name = "Tanhaçu", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 664, Name = "Tanque Novo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 665, Name = "Tanquinho", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 666, Name = "Taperoá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 667, Name = "Tapiramutá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 668, Name = "Teixeira de Freitas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 669, Name = "Teodoro Sampaio", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 670, Name = "Teofilândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 671, Name = "Teolândia", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 672, Name = "Terra Nova", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 673, Name = "Tremedal", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 674, Name = "Tucano", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 675, Name = "Uauá", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 676, Name = "Ubaíra", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 677, Name = "Ubaitaba", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 678, Name = "Ubatã", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 679, Name = "Uibaí", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 680, Name = "Umburanas", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 681, Name = "Una", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 682, Name = "Urandi", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 683, Name = "Uruçuca", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 684, Name = "Utinga", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 685, Name = "Valença", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 686, Name = "Valente", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 687, Name = "Várzea da Roça", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 688, Name = "Várzea do Poço", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 689, Name = "Várzea Nova", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 690, Name = "Varzedo", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 691, Name = "Vera Cruz", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 692, Name = "Vereda", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 693, Name = "Vitória da Conquista", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 694, Name = "Wagner", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 695, Name = "Wanderley", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 696, Name = "Wenceslau Guimarães", IdState = 5 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 697, Name = "Xique-Xique", IdState = 5 });
        }
        private static void Cities6(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 698, Name = "Abaiara", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 699, Name = "Acarape", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 700, Name = "Acaraú", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 701, Name = "Acopiara", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 702, Name = "Aiuaba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 703, Name = "Alcântaras", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 704, Name = "Altaneira", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 705, Name = "Alto Santo", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 706, Name = "Amontada", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 707, Name = "Antonina do Norte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 708, Name = "Apuiarés", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 709, Name = "Aquiraz", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 710, Name = "Aracati", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 711, Name = "Aracoiaba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 712, Name = "Ararendá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 713, Name = "Araripe", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 714, Name = "Aratuba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 715, Name = "Arneiroz", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 716, Name = "Assaré", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 717, Name = "Aurora", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 718, Name = "Baixio", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 719, Name = "Banabuiú", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 720, Name = "Barbalha", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 721, Name = "Barreira", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 722, Name = "Barro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 723, Name = "Barroquinha", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 724, Name = "Baturité", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 725, Name = "Beberibe", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 726, Name = "Bela Cruz", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 727, Name = "Boa Viagem", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 728, Name = "Brejo Santo", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 729, Name = "Camocim", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 730, Name = "Campos Sales", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 731, Name = "Canindé", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 732, Name = "Capistrano", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 733, Name = "Caridade", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 734, Name = "Cariré", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 735, Name = "Caririaçu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 736, Name = "Cariús", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 737, Name = "Carnaubal", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 738, Name = "Cascavel", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 739, Name = "Catarina", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 740, Name = "Catunda", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 741, Name = "Caucaia", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 742, Name = "Cedro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 743, Name = "Chaval", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 744, Name = "Choró", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 745, Name = "Chorozinho", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 746, Name = "Coreaú", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 747, Name = "Crateús", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 748, Name = "Crato", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 749, Name = "Croatá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 750, Name = "Cruz", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 751, Name = "Deputado Irapuan Pinheiro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 752, Name = "Ererê", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 753, Name = "Eusébio", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 754, Name = "Farias Brito", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 755, Name = "Forquilha", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 756, Name = "Fortaleza", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 757, Name = "Fortim", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 758, Name = "Frecheirinha", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 759, Name = "General Sampaio", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 760, Name = "Graça", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 761, Name = "Granja", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 762, Name = "Granjeiro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 763, Name = "Groaíras", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 764, Name = "Guaiúba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 765, Name = "Guaraciaba do Norte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 766, Name = "Guaramiranga", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 767, Name = "Hidrolândia", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 768, Name = "Horizonte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 769, Name = "Ibaretama", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 770, Name = "Ibiapina", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 771, Name = "Ibicuitinga", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 772, Name = "Icapuí", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 773, Name = "Icó", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 774, Name = "Iguatu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 775, Name = "Independência", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 776, Name = "Ipaporanga", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 777, Name = "Ipaumirim", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 778, Name = "Ipu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 779, Name = "Ipueiras", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 780, Name = "Iracema", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 781, Name = "Irauçuba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 782, Name = "Itaiçaba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 783, Name = "Itaitinga", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 784, Name = "Itapagé", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 785, Name = "Itapipoca", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 786, Name = "Itapiúna", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 787, Name = "Itarema", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 788, Name = "Itatira", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 789, Name = "Jaguaretama", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 790, Name = "Jaguaribara", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 791, Name = "Jaguaribe", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 792, Name = "Jaguaruana", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 793, Name = "Jardim", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 794, Name = "Jati", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 795, Name = "Jijoca de Jericoacoara", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 796, Name = "Juazeiro do Norte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 797, Name = "Jucás", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 798, Name = "Lavras da Mangabeira", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 799, Name = "Limoeiro do Norte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 800, Name = "Madalena", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 801, Name = "Maracanaú", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 802, Name = "Maranguape", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 803, Name = "Marco", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 804, Name = "Martinópole", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 805, Name = "Massapê", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 806, Name = "Mauriti", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 807, Name = "Meruoca", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 808, Name = "Milagres", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 809, Name = "Milhã", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 810, Name = "Miraíma", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 811, Name = "Missão Velha", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 812, Name = "Mombaça", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 813, Name = "Monsenhor Tabosa", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 814, Name = "Morada Nova", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 815, Name = "Moraújo", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 816, Name = "Morrinhos", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 817, Name = "Mucambo", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 818, Name = "Mulungu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 819, Name = "Nova Olinda", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 820, Name = "Nova Russas", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 821, Name = "Novo Oriente", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 822, Name = "Ocara", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 823, Name = "Orós", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 824, Name = "Pacajus", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 825, Name = "Pacatuba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 826, Name = "Pacoti", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 827, Name = "Pacujá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 828, Name = "Palhano", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 829, Name = "Palmácia", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 830, Name = "Paracuru", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 831, Name = "Paraipaba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 832, Name = "Parambu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 833, Name = "Paramoti", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 834, Name = "Pedra Branca", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 835, Name = "Penaforte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 836, Name = "Pentecoste", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 837, Name = "Pereiro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 838, Name = "Pindoretama", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 839, Name = "Piquet Carneiro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 840, Name = "Pires Ferreira", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 841, Name = "Poranga", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 842, Name = "Porteiras", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 843, Name = "Potengi", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 844, Name = "Potiretama", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 845, Name = "Quiterianópolis", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 846, Name = "Quixadá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 847, Name = "Quixelô", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 848, Name = "Quixeramobim", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 849, Name = "Quixeré", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 850, Name = "Redenção", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 851, Name = "Reriutaba", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 852, Name = "Russas", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 853, Name = "Saboeiro", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 854, Name = "Salitre", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 855, Name = "Santa Quitéria", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 856, Name = "Santana do Acaraú", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 857, Name = "Santana do Cariri", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 858, Name = "São Benedito", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 859, Name = "São Gonçalo do Amarante", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 860, Name = "São João do Jaguaribe", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 861, Name = "São Luís do Curu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 862, Name = "Senador Pompeu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 863, Name = "Senador Sá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 864, Name = "Sobral", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 865, Name = "Solonópole", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 866, Name = "Tabuleiro do Norte", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 867, Name = "Tamboril", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 868, Name = "Tarrafas", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 869, Name = "Tauá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 870, Name = "Tejuçuoca", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 871, Name = "Tianguá", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 872, Name = "Trairi", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 873, Name = "Tururu", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 874, Name = "Ubajara", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 875, Name = "Umari", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 876, Name = "Umirim", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 877, Name = "Uruburetama", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 878, Name = "Uruoca", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 879, Name = "Varjota", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 880, Name = "Várzea Alegre", IdState = 6 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 881, Name = "Viçosa do Ceará", IdState = 6 });
        }
        private static void Cities7(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 882, Name = "Brasília", IdState = 7 });
        }
        private static void Cities8(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1, Name = "Afonso Cláudio", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2, Name = "Água Doce do Norte", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3, Name = "Águia Branca", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4, Name = "Alegre", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5, Name = "Alfredo Chaves", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 6, Name = "Alto Rio Novo", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 7, Name = "Anchieta", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 8, Name = "Apiacá", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 9, Name = "Aracruz", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 10, Name = "Atilio Vivacqua", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 11, Name = "Baixo Guandu", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 12, Name = "Barra de São Francisco", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 13, Name = "Boa Esperança", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 14, Name = "Bom Jesus do Norte", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 15, Name = "Brejetuba", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 16, Name = "Cachoeiro de Itapemirim", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 17, Name = "Cariacica", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 18, Name = "Castelo", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 19, Name = "Colatina", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 20, Name = "Conceição da Barra", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 21, Name = "Conceição do Castelo", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 22, Name = "Divino de São Lourenço", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 23, Name = "Domingos Martins", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 24, Name = "Dores do Rio Preto", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 25, Name = "Ecoporanga", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 26, Name = "Fundão", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 27, Name = "Governador Lindenberg", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 28, Name = "Guaçuí", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 29, Name = "Guarapari", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 30, Name = "Ibatiba", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 31, Name = "Ibiraçu", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 32, Name = "Ibitirama", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 33, Name = "Iconha", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 34, Name = "Irupi", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 35, Name = "Itaguaçu", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 36, Name = "Itapemirim", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 37, Name = "Itarana", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 38, Name = "Iúna", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 39, Name = "Jaguaré", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 40, Name = "Jerônimo Monteiro", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 41, Name = "João Neiva", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 42, Name = "Laranja da Terra", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 43, Name = "Linhares", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 44, Name = "Mantenópolis", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 45, Name = "Marataízes", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 46, Name = "Marechal Floriano", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 47, Name = "Marilândia", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 48, Name = "Mimoso do Sul", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 49, Name = "Montanha", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 50, Name = "Mucurici", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 51, Name = "Muniz Freire", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 52, Name = "Muqui", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 53, Name = "Nova Venécia", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 54, Name = "Pancas", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 55, Name = "Pedro Canário", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 56, Name = "Pinheiros", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 57, Name = "Piúma", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 58, Name = "Ponto Belo", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 59, Name = "Presidente Kennedy", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 60, Name = "Rio Bananal", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 61, Name = "Rio Novo do Sul", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 62, Name = "Santa Leopoldina", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 63, Name = "Santa Maria de Jetibá", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 64, Name = "Santa Teresa", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 65, Name = "São Domingos do Norte", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 66, Name = "São Gabriel da Palha", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 67, Name = "São José do Calçado", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 68, Name = "São Mateus", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 69, Name = "São Roque do Canaã", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 70, Name = "Serra", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 71, Name = "Sooretama", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 72, Name = "Vargem Alta", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 73, Name = "Venda Nova do Imigrante", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 74, Name = "Viana", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 75, Name = "Vila Pavão", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 76, Name = "Vila Valério", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 77, Name = "Vila Velha", IdState = 8 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 78, Name = "Vitória", IdState = 8 });
        }
        private static void Cities9(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 883, Name = "Abadia de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 884, Name = "Abadiânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 885, Name = "Acreúna", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 886, Name = "Adelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 887, Name = "Água Fria de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 888, Name = "Água Limpa", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 889, Name = "Águas Lindas de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 890, Name = "Alexânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 891, Name = "Aloândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 892, Name = "Alto Horizonte", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 893, Name = "Alto Paraíso de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 894, Name = "Alvorada do Norte", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 895, Name = "Amaralina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 896, Name = "Americano do Brasil", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 897, Name = "Amorinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 898, Name = "Anápolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 899, Name = "Anhanguera", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 900, Name = "Anicuns", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 901, Name = "Aparecida de Goiânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 902, Name = "Aparecida do Rio Doce", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 903, Name = "Aporé", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 904, Name = "Araçu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 905, Name = "Aragarças", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 906, Name = "Aragoiânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 907, Name = "Araguapaz", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 908, Name = "Arenópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 909, Name = "Aruanã", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 910, Name = "Aurilândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 911, Name = "Avelinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 912, Name = "Baliza", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 913, Name = "Barro Alto", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 914, Name = "Bela Vista de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 915, Name = "Bom Jardim de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 916, Name = "Bom Jesus de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 917, Name = "Bonfinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 918, Name = "Bonópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 919, Name = "Brazabrantes", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 920, Name = "Britânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 921, Name = "Buriti Alegre", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 922, Name = "Buriti de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 923, Name = "Buritinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 924, Name = "Cabeceiras", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 925, Name = "Cachoeira Alta", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 926, Name = "Cachoeira de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 927, Name = "Cachoeira Dourada", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 928, Name = "Caçu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 929, Name = "Caiapônia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 930, Name = "Caldas Novas", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 931, Name = "Caldazinha", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 932, Name = "Campestre de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 933, Name = "Campinaçu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 934, Name = "Campinorte", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 935, Name = "Campo Alegre de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 936, Name = "Campo Limpo de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 937, Name = "Campos Belos", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 938, Name = "Campos Verdes", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 939, Name = "Carmo do Rio Verde", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 940, Name = "Castelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 941, Name = "Catalão", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 942, Name = "Caturaí", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 943, Name = "Cavalcante", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 944, Name = "Ceres", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 945, Name = "Cezarina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 946, Name = "Chapadão do Céu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 947, Name = "Cidade Ocidental", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 948, Name = "Cocalzinho de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 949, Name = "Colinas do Sul", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 950, Name = "Córrego do Ouro", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 951, Name = "Corumbá de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 952, Name = "Corumbaíba", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 953, Name = "Cristalina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 954, Name = "Cristianópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 955, Name = "Crixás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 956, Name = "Cromínia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 957, Name = "Cumari", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 958, Name = "Damianópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 959, Name = "Damolândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 960, Name = "Davinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 961, Name = "Diorama", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 962, Name = "Divinópolis de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 963, Name = "Doverlândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 964, Name = "Edealina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 965, Name = "Edéia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 966, Name = "Estrela do Norte", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 967, Name = "Faina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 968, Name = "Fazenda Nova", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 969, Name = "Firminópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 970, Name = "Flores de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 971, Name = "Formosa", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 972, Name = "Formoso", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 973, Name = "Gameleira de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 974, Name = "Goianápolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 975, Name = "Goiandira", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 976, Name = "Goianésia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 977, Name = "Goiânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 978, Name = "Goianira", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 979, Name = "Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 980, Name = "Goiatuba", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 981, Name = "Gouvelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 982, Name = "Guapó", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 983, Name = "Guaraíta", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 984, Name = "Guarani de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 985, Name = "Guarinos", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 986, Name = "Heitoraí", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 987, Name = "Hidrolândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 988, Name = "Hidrolina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 989, Name = "Iaciara", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 990, Name = "Inaciolândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 991, Name = "Indiara", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 992, Name = "Inhumas", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 993, Name = "Ipameri", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 994, Name = "Ipiranga de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 995, Name = "Iporá", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 996, Name = "Israelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 997, Name = "Itaberaí", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 998, Name = "Itaguari", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 999, Name = "Itaguaru", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1000, Name = "Itajá", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1001, Name = "Itapaci", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1002, Name = "Itapirapuã", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1003, Name = "Itapuranga", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1004, Name = "Itarumã", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1005, Name = "Itauçu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1006, Name = "Itumbiara", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1007, Name = "Ivolândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1008, Name = "Jandaia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1009, Name = "Jaraguá", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1010, Name = "Jataí", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1011, Name = "Jaupaci", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1012, Name = "Jesúpolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1013, Name = "Joviânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1014, Name = "Jussara", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1015, Name = "Lagoa Santa", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1016, Name = "Leopoldo de Bulhões", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1017, Name = "Luziânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1018, Name = "Mairipotaba", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1019, Name = "Mambaí", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1020, Name = "Mara Rosa", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1021, Name = "Marzagão", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1022, Name = "Matrinchã", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1023, Name = "Maurilândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1024, Name = "Mimoso de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1025, Name = "Minaçu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1026, Name = "Mineiros", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1027, Name = "Moiporá", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1028, Name = "Monte Alegre de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1029, Name = "Montes Claros de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1030, Name = "Montividiu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1031, Name = "Montividiu do Norte", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1032, Name = "Morrinhos", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1033, Name = "Morro Agudo de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1034, Name = "Mossâmedes", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1035, Name = "Mozarlândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1036, Name = "Mundo Novo", IdState = 9 });

            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1037, Name = "Mutunópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1038, Name = "Nazário", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1039, Name = "Nerópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1040, Name = "Niquelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1041, Name = "Nova América", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1042, Name = "Nova Aurora", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1043, Name = "Nova Crixás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1044, Name = "Nova Glória", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1045, Name = "Nova Iguaçu de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1046, Name = "Nova Roma", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1047, Name = "Nova Veneza", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1048, Name = "Novo Brasil", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1049, Name = "Novo Gama", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1050, Name = "Novo Planalto", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1051, Name = "Orizona", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1052, Name = "Ouro Verde de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1053, Name = "Ouvidor", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1054, Name = "Padre Bernardo", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1055, Name = "Palestina de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1056, Name = "Palmeiras de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1057, Name = "Palmelo", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1058, Name = "Palminópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1059, Name = "Panamá", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1060, Name = "Paranaiguara", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1061, Name = "Paraúna", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1062, Name = "Perolândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1063, Name = "Petrolina de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1064, Name = "Pilar de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1065, Name = "Piracanjuba", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1066, Name = "Piranhas", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1067, Name = "Pirenópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1068, Name = "Pires do Rio", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1069, Name = "Planaltina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1070, Name = "Pontalina", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1071, Name = "Porangatu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1072, Name = "Porteirão", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1073, Name = "Portelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1074, Name = "Posse", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1075, Name = "Professor Jamil", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1076, Name = "Quirinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1077, Name = "Rialma", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1078, Name = "Rianápolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1079, Name = "Rio Quente", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1080, Name = "Rio Verde", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1081, Name = "Rubiataba", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1082, Name = "Sanclerlândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1083, Name = "Santa Bárbara de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1084, Name = "Santa Cruz de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1085, Name = "Santa Fé de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1086, Name = "Santa Helena de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1087, Name = "Santa Isabel", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1088, Name = "Santa Rita do Araguaia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1089, Name = "Santa Rita do Novo Destino", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1090, Name = "Santa Rosa de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1091, Name = "Santa Tereza de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1092, Name = "Santa Terezinha de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1093, Name = "Santo Antônio da Barra", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1094, Name = "Santo Antônio de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1095, Name = "Santo Antônio do Descoberto", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1096, Name = "São Domingos", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1097, Name = "São Francisco de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1098, Name = "São João d`Aliança", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1099, Name = "São João da Paraúna", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1100, Name = "São Luís de Montes Belos", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1101, Name = "São Luíz do Norte", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1102, Name = "São Miguel do Araguaia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1103, Name = "São Miguel do Passa Quatro", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1104, Name = "São Patrício", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1105, Name = "São Simão", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1106, Name = "Senador Canedo", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1107, Name = "Serranópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1108, Name = "Silvânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1109, Name = "Simolândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1110, Name = "Sítio d`Abadia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1111, Name = "Taquaral de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1112, Name = "Teresina de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1113, Name = "Terezópolis de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1114, Name = "Três Ranchos", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1115, Name = "Trindade", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1116, Name = "Trombas", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1117, Name = "Turvânia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1118, Name = "Turvelândia", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1119, Name = "Uirapuru", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1120, Name = "Uruaçu", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1121, Name = "Uruana", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1122, Name = "Urutaí", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1123, Name = "Valparaíso de Goiás", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1124, Name = "Varjão", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1125, Name = "Vianópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1126, Name = "Vicentinópolis", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1127, Name = "Vila Boa", IdState = 9 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1128, Name = "Vila Propício", IdState = 9 });
        }
        private static void Cities10(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1129, Name = "Açailândia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1130, Name = "Afonso Cunha", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1131, Name = "Água Doce do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1132, Name = "Alcântara", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1133, Name = "Aldeias Altas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1134, Name = "Altamira do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1135, Name = "Alto Alegre do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1136, Name = "Alto Alegre do Pindaré", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1137, Name = "Alto Parnaíba", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1138, Name = "Amapá do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1139, Name = "Amarante do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1140, Name = "Anajatuba", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1141, Name = "Anapurus", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1142, Name = "Apicum-Açu", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1143, Name = "Araguanã", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1144, Name = "Araioses", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1145, Name = "Arame", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1146, Name = "Arari", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1147, Name = "Axixá", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1148, Name = "Bacabal", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1149, Name = "Bacabeira", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1150, Name = "Bacuri", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1151, Name = "Bacurituba", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1152, Name = "Balsas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1153, Name = "Barão de Grajaú", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1154, Name = "Barra do Corda", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1155, Name = "Barreirinhas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1156, Name = "Bela Vista do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1157, Name = "Belágua", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1158, Name = "Benedito Leite", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1159, Name = "Bequimão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1160, Name = "Bernardo do Mearim", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1161, Name = "Boa Vista do Gurupi", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1162, Name = "Bom Jardim", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1163, Name = "Bom Jesus das Selvas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1164, Name = "Bom Lugar", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1165, Name = "Brejo", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1166, Name = "Brejo de Areia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1167, Name = "Buriti", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1168, Name = "Buriti Bravo", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1169, Name = "Buriticupu", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1170, Name = "Buritirana", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1171, Name = "Cachoeira Grande", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1172, Name = "Cajapió", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1173, Name = "Cajari", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1174, Name = "Campestre do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1175, Name = "Cândido Mendes", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1176, Name = "Cantanhede", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1177, Name = "Capinzal do Norte", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1178, Name = "Carolina", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1179, Name = "Carutapera", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1180, Name = "Caxias", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1181, Name = "Cedral", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1182, Name = "Central do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1183, Name = "Centro do Guilherme", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1184, Name = "Centro Novo do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1185, Name = "Chapadinha", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1186, Name = "Cidelândia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1187, Name = "Codó", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1188, Name = "Coelho Neto", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1189, Name = "Colinas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1190, Name = "Conceição do Lago-Açu", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1191, Name = "Coroatá", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1192, Name = "Cururupu", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1193, Name = "Davinópolis", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1194, Name = "Dom Pedro", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1195, Name = "Duque Bacelar", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1196, Name = "Esperantinópolis", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1197, Name = "Estreito", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1198, Name = "Feira Nova do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1199, Name = "Fernando Falcão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1200, Name = "Formosa da Serra Negra", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1201, Name = "Fortaleza dos Nogueiras", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1202, Name = "Fortuna", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1203, Name = "Godofredo Viana", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1204, Name = "Gonçalves Dias", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1205, Name = "Governador Archer", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1206, Name = "Governador Edison Lobão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1207, Name = "Governador Eugênio Barros", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1208, Name = "Governador Luiz Rocha", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1209, Name = "Governador Newton Bello", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1210, Name = "Governador Nunes Freire", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1211, Name = "Graça Aranha", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1212, Name = "Grajaú", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1213, Name = "Guimarães", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1214, Name = "Humberto de Campos", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1215, Name = "Icatu", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1216, Name = "Igarapé do Meio", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1217, Name = "Igarapé Grande", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1218, Name = "Imperatriz", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1219, Name = "Itaipava do Grajaú", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1220, Name = "Itapecuru Mirim", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1221, Name = "Itinga do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1222, Name = "Jatobá", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1223, Name = "Jenipapo dos Vieiras", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1224, Name = "João Lisboa", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1225, Name = "Joselândia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1226, Name = "Junco do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1227, Name = "Lago da Pedra", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1228, Name = "Lago do Junco", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1229, Name = "Lago dos Rodrigues", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1230, Name = "Lago Verde", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1231, Name = "Lagoa do Mato", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1232, Name = "Lagoa Grande do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1233, Name = "Lajeado Novo", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1234, Name = "Lima Campos", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1235, Name = "Loreto", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1236, Name = "Luís Domingues", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1237, Name = "Magalhães de Almeida", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1238, Name = "Maracaçumé", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1239, Name = "Marajá do Sena", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1240, Name = "Maranhãozinho", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1241, Name = "Mata Roma", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1242, Name = "Matinha", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1243, Name = "Matões", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1244, Name = "Matões do Norte", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1245, Name = "Milagres do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1246, Name = "Mirador", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1247, Name = "Miranda do Norte", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1248, Name = "Mirinzal", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1249, Name = "Monção", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1250, Name = "Montes Altos", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1251, Name = "Morros", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1252, Name = "Nina Rodrigues", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1253, Name = "Nova Colinas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1254, Name = "Nova Iorque", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1255, Name = "Nova Olinda do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1256, Name = "Olho d`Água das Cunhãs", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1257, Name = "Olinda Nova do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1258, Name = "Paço do Lumiar", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1259, Name = "Palmeirândia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1260, Name = "Paraibano", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1261, Name = "Parnarama", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1262, Name = "Passagem Franca", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1263, Name = "Pastos Bons", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1264, Name = "Paulino Neves", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1265, Name = "Paulo Ramos", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1266, Name = "Pedreiras", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1267, Name = "Pedro do Rosário", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1268, Name = "Penalva", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1269, Name = "Peri Mirim", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1270, Name = "Peritoró", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1271, Name = "Pindaré-Mirim", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1272, Name = "Pinheiro", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1273, Name = "Pio XII", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1274, Name = "Pirapemas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1275, Name = "Poção de Pedras", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1276, Name = "Porto Franco", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1277, Name = "Porto Rico do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1278, Name = "Presidente Dutra", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1279, Name = "Presidente Juscelino", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1280, Name = "Presidente Médici", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1281, Name = "Presidente Sarney", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1282, Name = "Presidente Vargas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1283, Name = "Primeira Cruz", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1284, Name = "Raposa", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1285, Name = "Riachão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1286, Name = "Ribamar Fiquene", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1287, Name = "Rosário", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1288, Name = "Sambaíba", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1289, Name = "Santa Filomena do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1290, Name = "Santa Helena", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1291, Name = "Santa Inês", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1292, Name = "Santa Luzia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1293, Name = "Santa Luzia do Paruá", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1294, Name = "Santa Quitéria do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1295, Name = "Santa Rita", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1296, Name = "Santana do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1297, Name = "Santo Amaro do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1298, Name = "Santo Antônio dos Lopes", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1299, Name = "São Benedito do Rio Preto", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1300, Name = "São Bento", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1301, Name = "São Bernardo", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1302, Name = "São Domingos do Azeitão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1303, Name = "São Domingos do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1304, Name = "São Félix de Balsas", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1305, Name = "São Francisco do Brejão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1306, Name = "São Francisco do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1307, Name = "São João Batista", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1308, Name = "São João do Carú", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1309, Name = "São João do Paraíso", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1310, Name = "São João do Soter", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1311, Name = "São João dos Patos", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1312, Name = "São José de Ribamar", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1313, Name = "São José dos Basílios", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1314, Name = "São Luís", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1315, Name = "São Luís Gonzaga do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1316, Name = "São Mateus do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1317, Name = "São Pedro da Água Branca", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1318, Name = "São Pedro dos Crentes", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1319, Name = "São Raimundo das Mangabeiras", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1320, Name = "São Raimundo do Doca Bezerra", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1321, Name = "São Roberto", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1322, Name = "São Vicente Ferrer", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1323, Name = "Satubinha", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1324, Name = "Senador Alexandre Costa", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1325, Name = "Senador La Rocque", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1326, Name = "Serrano do Maranhão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1327, Name = "Sítio Novo", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1328, Name = "Sucupira do Norte", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1329, Name = "Sucupira do Riachão", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1330, Name = "Tasso Fragoso", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1331, Name = "Timbiras", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1332, Name = "Timon", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1333, Name = "Trizidela do Vale", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1334, Name = "Tufilândia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1335, Name = "Tuntum", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1336, Name = "Turiaçu", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1337, Name = "Turilândia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1338, Name = "Tutóia", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1339, Name = "Urbano Santos", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1340, Name = "Vargem Grande", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1341, Name = "Viana", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1342, Name = "Vila Nova dos Martírios", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1343, Name = "Vitória do Mearim", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1344, Name = "Vitorino Freire", IdState = 10 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1345, Name = "Zé Doca", IdState = 10 });
        }
        private static void Cities11(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1565, Name = "Abadia dos Dourados", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1566, Name = "Abaeté", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1567, Name = "Abre Campo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1568, Name = "Acaiaca", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1569, Name = "Açucena", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1570, Name = "Água Boa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1571, Name = "Água Comprida", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1572, Name = "Aguanil", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1573, Name = "Águas Formosas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1574, Name = "Águas Vermelhas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1575, Name = "Aimorés", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1576, Name = "Aiuruoca", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1577, Name = "Alagoa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1578, Name = "Albertina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1579, Name = "Além Paraíba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1580, Name = "Alfenas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1581, Name = "Alfredo Vasconcelos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1582, Name = "Almenara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1583, Name = "Alpercata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1584, Name = "Alpinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1585, Name = "Alterosa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1586, Name = "Alto Caparaó", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1587, Name = "Alto Jequitibá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1588, Name = "Alto Rio Doce", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1589, Name = "Alvarenga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1590, Name = "Alvinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1591, Name = "Alvorada de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1592, Name = "Amparo do Serra", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1593, Name = "Andradas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1594, Name = "Andrelândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1595, Name = "Angelândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1596, Name = "Antônio Carlos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1597, Name = "Antônio Dias", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1598, Name = "Antônio Prado de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1599, Name = "Araçaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1600, Name = "Aracitaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1601, Name = "Araçuaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1602, Name = "Araguari", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1603, Name = "Arantina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1604, Name = "Araponga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1605, Name = "Araporã", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1606, Name = "Arapuá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1607, Name = "Araújos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1608, Name = "Araxá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1609, Name = "Arceburgo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1610, Name = "Arcos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1611, Name = "Areado", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1612, Name = "Argirita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1613, Name = "Aricanduva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1614, Name = "Arinos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1615, Name = "Astolfo Dutra", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1616, Name = "Ataléia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1617, Name = "Augusto de Lima", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1618, Name = "Baependi", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1619, Name = "Baldim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1620, Name = "Bambuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1621, Name = "Bandeira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1622, Name = "Bandeira do Sul", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1623, Name = "Barão de Cocais", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1624, Name = "Barão de Monte Alto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1625, Name = "Barbacena", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1626, Name = "Barra Longa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1627, Name = "Barroso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1628, Name = "Bela Vista de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1629, Name = "Belmiro Braga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1630, Name = "Belo Horizonte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1631, Name = "Belo Oriente", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1632, Name = "Belo Vale", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1633, Name = "Berilo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1634, Name = "Berizal", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1635, Name = "Bertópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1636, Name = "Betim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1637, Name = "Bias Fortes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1638, Name = "Bicas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1639, Name = "Biquinhas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1640, Name = "Boa Esperança", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1641, Name = "Bocaina de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1642, Name = "Bocaiúva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1643, Name = "Bom Despacho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1644, Name = "Bom Jardim de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1645, Name = "Bom Jesus da Penha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1646, Name = "Bom Jesus do Amparo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1647, Name = "Bom Jesus do Galho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1648, Name = "Bom Repouso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1649, Name = "Bom Sucesso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1650, Name = "Bonfim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1651, Name = "Bonfinópolis de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1652, Name = "Bonito de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1653, Name = "Borda da Mata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1654, Name = "Botelhos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1655, Name = "Botumirim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1656, Name = "Brás Pires", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1657, Name = "Brasilândia de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1658, Name = "Brasília de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1659, Name = "Brasópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1660, Name = "Braúnas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1661, Name = "Brumadinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1662, Name = "Bueno Brandão", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1663, Name = "Buenópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1664, Name = "Bugre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1665, Name = "Buritis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1666, Name = "Buritizeiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1667, Name = "Cabeceira Grande", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1668, Name = "Cabo Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1669, Name = "Cachoeira da Prata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1670, Name = "Cachoeira de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1671, Name = "Cachoeira de Pajeú", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1672, Name = "Cachoeira Dourada", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1673, Name = "Caetanópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1674, Name = "Caeté", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1675, Name = "Caiana", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1676, Name = "Cajuri", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1677, Name = "Caldas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1678, Name = "Camacho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1679, Name = "Camanducaia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1680, Name = "Cambuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1681, Name = "Cambuquira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1682, Name = "Campanário", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1683, Name = "Campanha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1684, Name = "Campestre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1685, Name = "Campina Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1686, Name = "Campo Azul", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1687, Name = "Campo Belo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1688, Name = "Campo do Meio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1689, Name = "Campo Florido", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1690, Name = "Campos Altos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1691, Name = "Campos Gerais", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1692, Name = "Cana Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1693, Name = "Canaã", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1694, Name = "Canápolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1695, Name = "Candeias", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1696, Name = "Cantagalo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1697, Name = "Caparaó", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1698, Name = "Capela Nova", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1699, Name = "Capelinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1700, Name = "Capetinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1701, Name = "Capim Branco", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1702, Name = "Capinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1703, Name = "Capitão Andrade", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1704, Name = "Capitão Enéas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1705, Name = "Capitólio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1706, Name = "Caputira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1707, Name = "Caraí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1708, Name = "Caranaíba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1709, Name = "Carandaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1710, Name = "Carangola", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1711, Name = "Caratinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1712, Name = "Carbonita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1713, Name = "Careaçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1714, Name = "Carlos Chagas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1715, Name = "Carmésia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1716, Name = "Carmo da Cachoeira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1717, Name = "Carmo da Mata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1718, Name = "Carmo de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1719, Name = "Carmo do Cajuru", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1720, Name = "Carmo do Paranaíba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1721, Name = "Carmo do Rio Claro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1722, Name = "Carmópolis de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1723, Name = "Carneirinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1724, Name = "Carrancas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1725, Name = "Carvalhópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1726, Name = "Carvalhos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1727, Name = "Casa Grande", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1728, Name = "Cascalho Rico", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1729, Name = "Cássia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1730, Name = "Cataguases", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1731, Name = "Catas Altas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1732, Name = "Catas Altas da Noruega", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1733, Name = "Catuji", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1734, Name = "Catuti", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1735, Name = "Caxambu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1736, Name = "Cedro do Abaeté", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1737, Name = "Central de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1738, Name = "Centralina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1739, Name = "Chácara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1740, Name = "Chalé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1741, Name = "Chapada do Norte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1742, Name = "Chapada Gaúcha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1743, Name = "Chiador", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1744, Name = "Cipotânea", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1745, Name = "Claraval", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1746, Name = "Claro dos Poções", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1747, Name = "Cláudio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1748, Name = "Coimbra", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1749, Name = "Coluna", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1750, Name = "Comendador Gomes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1751, Name = "Comercinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1752, Name = "Conceição da Aparecida", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1753, Name = "Conceição da Barra de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1754, Name = "Conceição das Alagoas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1755, Name = "Conceição das Pedras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1756, Name = "Conceição de Ipanema", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1757, Name = "Conceição do Mato Dentro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1758, Name = "Conceição do Pará", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1759, Name = "Conceição do Rio Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1760, Name = "Conceição dos Ouros", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1761, Name = "Cônego Marinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1762, Name = "Confins", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1763, Name = "Congonhal", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1764, Name = "Congonhas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1765, Name = "Congonhas do Norte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1766, Name = "Conquista", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1767, Name = "Conselheiro Lafaiete", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1768, Name = "Conselheiro Pena", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1769, Name = "Consolação", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1770, Name = "Contagem", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1771, Name = "Coqueiral", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1772, Name = "Coração de Jesus", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1773, Name = "Cordisburgo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1774, Name = "Cordislândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1775, Name = "Corinto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1776, Name = "Coroaci", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1777, Name = "Coromandel", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1778, Name = "Coronel Fabriciano", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1779, Name = "Coronel Murta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1780, Name = "Coronel Pacheco", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1781, Name = "Coronel Xavier Chaves", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1782, Name = "Córrego Danta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1783, Name = "Córrego do Bom Jesus", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1784, Name = "Córrego Fundo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1785, Name = "Córrego Novo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1786, Name = "Couto de Magalhães de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1787, Name = "Crisólita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1788, Name = "Cristais", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1789, Name = "Cristália", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1790, Name = "Cristiano Otoni", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1791, Name = "Cristina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1792, Name = "Crucilândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1793, Name = "Cruzeiro da Fortaleza", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1794, Name = "Cruzília", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1795, Name = "Cuparaque", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1796, Name = "Curral de Dentro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1797, Name = "Curvelo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1798, Name = "Datas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1799, Name = "Delfim Moreira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1800, Name = "Delfinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1801, Name = "Delta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1802, Name = "Descoberto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1803, Name = "Desterro de Entre Rios", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1804, Name = "Desterro do Melo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1805, Name = "Diamantina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1806, Name = "Diogo de Vasconcelos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1807, Name = "Dionísio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1808, Name = "Divinésia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1809, Name = "Divino", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1810, Name = "Divino das Laranjeiras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1811, Name = "Divinolândia de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1812, Name = "Divinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1813, Name = "Divisa Alegre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1814, Name = "Divisa Nova", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1815, Name = "Divisópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1816, Name = "Dom Bosco", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1817, Name = "Dom Cavati", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1818, Name = "Dom Joaquim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1819, Name = "Dom Silvério", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1820, Name = "Dom Viçoso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1821, Name = "Dona Eusébia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1822, Name = "Dores de Campos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1823, Name = "Dores de Guanhães", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1824, Name = "Dores do Indaiá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1825, Name = "Dores do Turvo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1826, Name = "Doresópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1827, Name = "Douradoquara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1828, Name = "Durandé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1829, Name = "Elói Mendes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1830, Name = "Engenheiro Caldas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1831, Name = "Engenheiro Navarro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1832, Name = "Entre Folhas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1833, Name = "Entre Rios de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1834, Name = "Ervália", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1835, Name = "Esmeraldas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1836, Name = "Espera Feliz", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1837, Name = "Espinosa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1838, Name = "Espírito Santo do Dourado", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1839, Name = "Estiva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1840, Name = "Estrela Dalva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1841, Name = "Estrela do Indaiá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1842, Name = "Estrela do Sul", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1843, Name = "Eugenópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1844, Name = "Ewbank da Câmara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1845, Name = "Extrema", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1846, Name = "Fama", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1847, Name = "Faria Lemos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1848, Name = "Felício dos Santos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1849, Name = "Felisburgo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1850, Name = "Felixlândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1851, Name = "Fernandes Tourinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1852, Name = "Ferros", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1853, Name = "Fervedouro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1854, Name = "Florestal", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1855, Name = "Formiga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1856, Name = "Formoso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1857, Name = "Fortaleza de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1858, Name = "Fortuna de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1859, Name = "Francisco Badaró", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1860, Name = "Francisco Dumont", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1861, Name = "Francisco Sá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1862, Name = "Franciscópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1863, Name = "Frei Gaspar", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1864, Name = "Frei Inocêncio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1865, Name = "Frei Lagonegro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1866, Name = "Fronteira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1867, Name = "Fronteira dos Vales", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1868, Name = "Fruta de Leite", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1869, Name = "Frutal", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1870, Name = "Funilândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1871, Name = "Galiléia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1872, Name = "Gameleiras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1873, Name = "Glaucilândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1874, Name = "Goiabeira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1875, Name = "Goianá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1876, Name = "Gonçalves", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1877, Name = "Gonzaga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1878, Name = "Gouveia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1879, Name = "Governador Valadares", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1880, Name = "Grão Mogol", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1881, Name = "Grupiara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1882, Name = "Guanhães", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1883, Name = "Guapé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1884, Name = "Guaraciaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1885, Name = "Guaraciama", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1886, Name = "Guaranésia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1887, Name = "Guarani", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1888, Name = "Guarará", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1889, Name = "Guarda-Mor", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1890, Name = "Guaxupé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1891, Name = "Guidoval", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1892, Name = "Guimarânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1893, Name = "Guiricema", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1894, Name = "Gurinhatã", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1895, Name = "Heliodora", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1896, Name = "Iapu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1897, Name = "Ibertioga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1898, Name = "Ibiá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1899, Name = "Ibiaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1900, Name = "Ibiracatu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1901, Name = "Ibiraci", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1902, Name = "Ibirité", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1903, Name = "Ibitiúra de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1904, Name = "Ibituruna", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1905, Name = "Icaraí de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1906, Name = "Igarapé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1907, Name = "Igaratinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1908, Name = "Iguatama", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1909, Name = "Ijaci", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1910, Name = "Ilicínea", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1911, Name = "Imbé de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1912, Name = "Inconfidentes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1913, Name = "Indaiabira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1914, Name = "Indianópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1915, Name = "Ingaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1916, Name = "Inhapim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1917, Name = "Inhaúma", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1918, Name = "Inimutaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1919, Name = "Ipaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1920, Name = "Ipanema", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1921, Name = "Ipatinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1922, Name = "Ipiaçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1923, Name = "Ipuiúna", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1924, Name = "Iraí de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1925, Name = "Itabira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1926, Name = "Itabirinha de Mantena", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1927, Name = "Itabirito", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1928, Name = "Itacambira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1929, Name = "Itacarambi", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1930, Name = "Itaguara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1931, Name = "Itaipé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1932, Name = "Itajubá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1933, Name = "Itamarandiba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1934, Name = "Itamarati de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1935, Name = "Itambacuri", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1936, Name = "Itambé do Mato Dentro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1937, Name = "Itamogi", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1938, Name = "Itamonte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1939, Name = "Itanhandu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1940, Name = "Itanhomi", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1941, Name = "Itaobim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1942, Name = "Itapagipe", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1943, Name = "Itapecerica", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1944, Name = "Itapeva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1945, Name = "Itatiaiuçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1946, Name = "Itaú de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1947, Name = "Itaúna", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1948, Name = "Itaverava", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1949, Name = "Itinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1950, Name = "Itueta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1951, Name = "Ituiutaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1952, Name = "Itumirim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1953, Name = "Iturama", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1954, Name = "Itutinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1955, Name = "Jaboticatubas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1956, Name = "Jacinto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1957, Name = "Jacuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1958, Name = "Jacutinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1959, Name = "Jaguaraçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1960, Name = "Jaíba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1961, Name = "Jampruca", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1962, Name = "Janaúba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1963, Name = "Januária", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1964, Name = "Japaraíba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1965, Name = "Japonvar", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1966, Name = "Jeceaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1967, Name = "Jenipapo de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1968, Name = "Jequeri", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1969, Name = "Jequitaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1970, Name = "Jequitibá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1971, Name = "Jequitinhonha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1972, Name = "Jesuânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1973, Name = "Joaíma", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1974, Name = "Joanésia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1975, Name = "João Monlevade", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1976, Name = "João Pinheiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1977, Name = "Joaquim Felício", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1978, Name = "Jordânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1979, Name = "José Gonçalves de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1980, Name = "José Raydan", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1981, Name = "Josenópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1982, Name = "Juatuba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1983, Name = "Juiz de Fora", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1984, Name = "Juramento", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1985, Name = "Juruaia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1986, Name = "Juvenília", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1987, Name = "Ladainha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1988, Name = "Lagamar", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1989, Name = "Lagoa da Prata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1990, Name = "Lagoa dos Patos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1991, Name = "Lagoa Dourada", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1992, Name = "Lagoa Formosa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1993, Name = "Lagoa Grande", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1994, Name = "Lagoa Santa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1995, Name = "Lajinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1996, Name = "Lambari", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1997, Name = "Lamim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1998, Name = "Laranjal", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1999, Name = "Lassance", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2000, Name = "Lavras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2001, Name = "Leandro Ferreira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2002, Name = "Leme do Prado", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2003, Name = "Leopoldina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2004, Name = "Liberdade", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2005, Name = "Lima Duarte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2006, Name = "Limeira do Oeste", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2007, Name = "Lontra", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2008, Name = "Luisburgo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2009, Name = "Luislândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2010, Name = "Luminárias", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2011, Name = "Luz", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2012, Name = "Machacalis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2013, Name = "Machado", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2014, Name = "Madre de Deus de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2015, Name = "Malacacheta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2016, Name = "Mamonas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2017, Name = "Manga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2018, Name = "Manhuaçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2019, Name = "Manhumirim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2020, Name = "Mantena", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2021, Name = "Mar de Espanha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2022, Name = "Maravilhas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2023, Name = "Maria da Fé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2024, Name = "Mariana", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2025, Name = "Marilac", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2026, Name = "Mário Campos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2027, Name = "Maripá de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2028, Name = "Marliéria", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2029, Name = "Marmelópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2030, Name = "Martinho Campos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2031, Name = "Martins Soares", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2032, Name = "Mata Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2033, Name = "Materlândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2034, Name = "Mateus Leme", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2035, Name = "Mathias Lobato", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2036, Name = "Matias Barbosa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2037, Name = "Matias Cardoso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2038, Name = "Matipó", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2039, Name = "Mato Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2040, Name = "Matozinhos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2041, Name = "Matutina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2042, Name = "Medeiros", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2043, Name = "Medina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2044, Name = "Mendes Pimentel", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2045, Name = "Mercês", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2046, Name = "Mesquita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2047, Name = "Minas Novas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2048, Name = "Minduri", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2049, Name = "Mirabela", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2050, Name = "Miradouro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2051, Name = "Miraí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2052, Name = "Miravânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2053, Name = "Moeda", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2054, Name = "Moema", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2055, Name = "Monjolos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2056, Name = "Monsenhor Paulo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2057, Name = "Montalvânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2058, Name = "Monte Alegre de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2059, Name = "Monte Azul", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2060, Name = "Monte Belo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2061, Name = "Monte Carmelo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2062, Name = "Monte Formoso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2063, Name = "Monte Santo de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2064, Name = "Monte Sião", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2065, Name = "Montes Claros", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2066, Name = "Montezuma", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2067, Name = "Morada Nova de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2068, Name = "Morro da Garça", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2069, Name = "Morro do Pilar", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2070, Name = "Munhoz", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2071, Name = "Muriaé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2072, Name = "Mutum", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2073, Name = "Muzambinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2074, Name = "Nacip Raydan", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2075, Name = "Nanuque", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2076, Name = "Naque", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2077, Name = "Natalândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2078, Name = "Natércia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2079, Name = "Nazareno", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2080, Name = "Nepomuceno", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2081, Name = "Ninheira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2082, Name = "Nova Belém", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2083, Name = "Nova Era", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2084, Name = "Nova Lima", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2085, Name = "Nova Módica", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2086, Name = "Nova Ponte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2087, Name = "Nova Porteirinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2088, Name = "Nova Resende", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2089, Name = "Nova Serrana", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2090, Name = "Nova União", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2091, Name = "Novo Cruzeiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2092, Name = "Novo Oriente de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2093, Name = "Novorizonte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2094, Name = "Olaria", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2095, Name = "Olhos-d`Água", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2096, Name = "Olímpio Noronha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2097, Name = "Oliveira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2098, Name = "Oliveira Fortes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2099, Name = "Onça de Pitangui", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2100, Name = "Oratórios", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2101, Name = "Orizânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2102, Name = "Ouro Branco", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2103, Name = "Ouro Fino", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2104, Name = "Ouro Preto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2105, Name = "Ouro Verde de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2106, Name = "Padre Carvalho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2107, Name = "Padre Paraíso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2108, Name = "Pai Pedro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2109, Name = "Paineiras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2110, Name = "Pains", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2111, Name = "Paiva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2112, Name = "Palma", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2113, Name = "Palmópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2114, Name = "Papagaios", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2115, Name = "Pará de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2116, Name = "Paracatu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2117, Name = "Paraguaçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2118, Name = "Paraisópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2119, Name = "Paraopeba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2120, Name = "Passa Quatro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2121, Name = "Passa Tempo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2122, Name = "Passabém", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2123, Name = "Passa-Vinte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2124, Name = "Passos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2125, Name = "Patis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2126, Name = "Patos de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2127, Name = "Patrocínio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2128, Name = "Patrocínio do Muriaé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2129, Name = "Paula Cândido", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2130, Name = "Paulistas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2131, Name = "Pavão", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2132, Name = "Peçanha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2133, Name = "Pedra Azul", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2134, Name = "Pedra Bonita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2135, Name = "Pedra do Anta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2136, Name = "Pedra do Indaiá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2137, Name = "Pedra Dourada", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2138, Name = "Pedralva", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2139, Name = "Pedras de Maria da Cruz", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2140, Name = "Pedrinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2141, Name = "Pedro Leopoldo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2142, Name = "Pedro Teixeira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2143, Name = "Pequeri", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2144, Name = "Pequi", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2145, Name = "Perdigão", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2146, Name = "Perdizes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2147, Name = "Perdões", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2148, Name = "Periquito", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2149, Name = "Pescador", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2150, Name = "Piau", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2151, Name = "Piedade de Caratinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2152, Name = "Piedade de Ponte Nova", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2153, Name = "Piedade do Rio Grande", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2154, Name = "Piedade dos Gerais", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2155, Name = "Pimenta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2156, Name = "Pingo-d`Água", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2157, Name = "Pintópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2158, Name = "Piracema", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2159, Name = "Pirajuba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2160, Name = "Piranga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2161, Name = "Piranguçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2162, Name = "Piranguinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2163, Name = "Pirapetinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2164, Name = "Pirapora", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2165, Name = "Piraúba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2166, Name = "Pitangui", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2167, Name = "Piumhi", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2168, Name = "Planura", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2169, Name = "Poço Fundo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2170, Name = "Poços de Caldas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2171, Name = "Pocrane", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2172, Name = "Pompéu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2173, Name = "Ponte Nova", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2174, Name = "Ponto Chique", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2175, Name = "Ponto dos Volantes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2176, Name = "Porteirinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2177, Name = "Porto Firme", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2178, Name = "Poté", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2179, Name = "Pouso Alegre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2180, Name = "Pouso Alto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2181, Name = "Prados", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2182, Name = "Prata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2183, Name = "Pratápolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2184, Name = "Pratinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2185, Name = "Presidente Bernardes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2186, Name = "Presidente Juscelino", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2187, Name = "Presidente Kubitschek", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2188, Name = "Presidente Olegário", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2189, Name = "Prudente de Morais", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2190, Name = "Quartel Geral", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2191, Name = "Queluzito", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2192, Name = "Raposos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2193, Name = "Raul Soares", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2194, Name = "Recreio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2195, Name = "Reduto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2196, Name = "Resende Costa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2197, Name = "Resplendor", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2198, Name = "Ressaquinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2199, Name = "Riachinho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2200, Name = "Riacho dos Machados", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2201, Name = "Ribeirão das Neves", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2202, Name = "Ribeirão Vermelho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2203, Name = "Rio Acima", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2204, Name = "Rio Casca", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2205, Name = "Rio do Prado", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2206, Name = "Rio Doce", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2207, Name = "Rio Espera", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2208, Name = "Rio Manso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2209, Name = "Rio Novo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2210, Name = "Rio Paranaíba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2211, Name = "Rio Pardo de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2212, Name = "Rio Piracicaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2213, Name = "Rio Pomba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2214, Name = "Rio Preto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2215, Name = "Rio Vermelho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2216, Name = "Ritápolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2217, Name = "Rochedo de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2218, Name = "Rodeiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2219, Name = "Romaria", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2220, Name = "Rosário da Limeira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2221, Name = "Rubelita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2222, Name = "Rubim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2223, Name = "Sabará", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2224, Name = "Sabinópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2225, Name = "Sacramento", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2226, Name = "Salinas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2227, Name = "Salto da Divisa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2228, Name = "Santa Bárbara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2229, Name = "Santa Bárbara do Leste", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2230, Name = "Santa Bárbara do Monte Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2231, Name = "Santa Bárbara do Tugúrio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2232, Name = "Santa Cruz de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2233, Name = "Santa Cruz de Salinas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2234, Name = "Santa Cruz do Escalvado", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2235, Name = "Santa Efigênia de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2236, Name = "Santa Fé de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2237, Name = "Santa Helena de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2238, Name = "Santa Juliana", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2239, Name = "Santa Luzia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2240, Name = "Santa Margarida", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2241, Name = "Santa Maria de Itabira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2242, Name = "Santa Maria do Salto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2243, Name = "Santa Maria do Suaçuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2244, Name = "Santa Rita de Caldas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2245, Name = "Santa Rita de Ibitipoca", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2246, Name = "Santa Rita de Jacutinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2247, Name = "Santa Rita de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2248, Name = "Santa Rita do Itueto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2249, Name = "Santa Rita do Sapucaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2250, Name = "Santa Rosa da Serra", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2251, Name = "Santa Vitória", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2252, Name = "Santana da Vargem", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2253, Name = "Santana de Cataguases", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2254, Name = "Santana de Pirapama", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2255, Name = "Santana do Deserto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2256, Name = "Santana do Garambéu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2257, Name = "Santana do Jacaré", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2258, Name = "Santana do Manhuaçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2259, Name = "Santana do Paraíso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2260, Name = "Santana do Riacho", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2261, Name = "Santana dos Montes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2262, Name = "Santo Antônio do Amparo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2263, Name = "Santo Antônio do Aventureiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2264, Name = "Santo Antônio do Grama", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2265, Name = "Santo Antônio do Itambé", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2266, Name = "Santo Antônio do Jacinto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2267, Name = "Santo Antônio do Monte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2268, Name = "Santo Antônio do Retiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2269, Name = "Santo Antônio do Rio Abaixo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2270, Name = "Santo Hipólito", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2271, Name = "Santos Dumont", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2272, Name = "São Bento Abade", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2273, Name = "São Brás do Suaçuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2274, Name = "São Domingos das Dores", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2275, Name = "São Domingos do Prata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2276, Name = "São Félix de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2277, Name = "São Francisco", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2278, Name = "São Francisco de Paula", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2279, Name = "São Francisco de Sales", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2280, Name = "São Francisco do Glória", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2281, Name = "São Geraldo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2282, Name = "São Geraldo da Piedade", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2283, Name = "São Geraldo do Baixio", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2284, Name = "São Gonçalo do Abaeté", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2285, Name = "São Gonçalo do Pará", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2286, Name = "São Gonçalo do Rio Abaixo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2287, Name = "São Gonçalo do Rio Preto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2288, Name = "São Gonçalo do Sapucaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2289, Name = "São Gotardo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2290, Name = "São João Batista do Glória", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2291, Name = "São João da Lagoa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2292, Name = "São João da Mata", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2293, Name = "São João da Ponte", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2294, Name = "São João das Missões", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2295, Name = "São João del Rei", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2296, Name = "São João do Manhuaçu", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2297, Name = "São João do Manteninha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2298, Name = "São João do Oriente", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2299, Name = "São João do Pacuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2300, Name = "São João do Paraíso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2301, Name = "São João Evangelista", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2302, Name = "São João Nepomuceno", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2303, Name = "São Joaquim de Bicas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2304, Name = "São José da Barra", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2305, Name = "São José da Lapa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2306, Name = "São José da Safira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2307, Name = "São José da Varginha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2308, Name = "São José do Alegre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2309, Name = "São José do Divino", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2310, Name = "São José do Goiabal", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2311, Name = "São José do Jacuri", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2312, Name = "São José do Mantimento", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2313, Name = "São Lourenço", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2314, Name = "São Miguel do Anta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2315, Name = "São Pedro da União", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2316, Name = "São Pedro do Suaçuí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2317, Name = "São Pedro dos Ferros", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2318, Name = "São Romão", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2319, Name = "São Roque de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2320, Name = "São Sebastião da Bela Vista", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2321, Name = "São Sebastião da Vargem Alegre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2322, Name = "São Sebastião do Anta", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2323, Name = "São Sebastião do Maranhão", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2324, Name = "São Sebastião do Oeste", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2325, Name = "São Sebastião do Paraíso", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2326, Name = "São Sebastião do Rio Preto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2327, Name = "São Sebastião do Rio Verde", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2328, Name = "São Thomé das Letras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2329, Name = "São Tiago", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2330, Name = "São Tomás de Aquino", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2331, Name = "São Vicente de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2332, Name = "Sapucaí-Mirim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2333, Name = "Sardoá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2334, Name = "Sarzedo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2335, Name = "Sem-Peixe", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2336, Name = "Senador Amaral", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2337, Name = "Senador Cortes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2338, Name = "Senador Firmino", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2339, Name = "Senador José Bento", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2340, Name = "Senador Modestino Gonçalves", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2341, Name = "Senhora de Oliveira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2342, Name = "Senhora do Porto", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2343, Name = "Senhora dos Remédios", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2344, Name = "Sericita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2345, Name = "Seritinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2346, Name = "Serra Azul de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2347, Name = "Serra da Saudade", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2348, Name = "Serra do Salitre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2349, Name = "Serra dos Aimorés", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2350, Name = "Serrania", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2351, Name = "Serranópolis de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2352, Name = "Serranos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2353, Name = "Serro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2354, Name = "Sete Lagoas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2355, Name = "Setubinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2356, Name = "Silveirânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2357, Name = "Silvianópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2358, Name = "Simão Pereira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2359, Name = "Simonésia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2360, Name = "Sobrália", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2361, Name = "Soledade de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2362, Name = "Tabuleiro", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2363, Name = "Taiobeiras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2364, Name = "Taparuba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2365, Name = "Tapira", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2366, Name = "Tapiraí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2367, Name = "Taquaraçu de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2368, Name = "Tarumirim", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2369, Name = "Teixeiras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2370, Name = "Teófilo Otoni", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2371, Name = "Timóteo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2372, Name = "Tiradentes", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2373, Name = "Tiros", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2374, Name = "Tocantins", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2375, Name = "Tocos do Moji", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2376, Name = "Toledo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2377, Name = "Tombos", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2378, Name = "Três Corações", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2379, Name = "Três Marias", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2380, Name = "Três Pontas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2381, Name = "Tumiritinga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2382, Name = "Tupaciguara", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2383, Name = "Turmalina", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2384, Name = "Turvolândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2385, Name = "Ubá", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2386, Name = "Ubaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2387, Name = "Ubaporanga", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2388, Name = "Uberaba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2389, Name = "Uberlândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2390, Name = "Umburatiba", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2391, Name = "Unaí", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2392, Name = "União de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2393, Name = "Uruana de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2394, Name = "Urucânia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2395, Name = "Urucuia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2396, Name = "Vargem Alegre", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2397, Name = "Vargem Bonita", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2398, Name = "Vargem Grande do Rio Pardo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2399, Name = "Varginha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2400, Name = "Varjão de Minas", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2401, Name = "Várzea da Palma", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2402, Name = "Varzelândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2403, Name = "Vazante", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2404, Name = "Verdelândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2405, Name = "Veredinha", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2406, Name = "Veríssimo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2407, Name = "Vermelho Novo", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2408, Name = "Vespasiano", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2409, Name = "Viçosa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2410, Name = "Vieiras", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2411, Name = "Virgem da Lapa", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2412, Name = "Virgínia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2413, Name = "Virginópolis", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2414, Name = "Virgolândia", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2415, Name = "Visconde do Rio Branco", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2416, Name = "Volta Grande", IdState = 11 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2417, Name = "Wenceslau Braz", IdState = 11 });
        }
        private static void Cities12(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1487, Name = "Água Clara", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1488, Name = "Alcinópolis", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1489, Name = "Amambaí", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1490, Name = "Anastácio", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1491, Name = "Anaurilândia", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1492, Name = "Angélica", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1493, Name = "Antônio João", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1494, Name = "Aparecida do Taboado", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1495, Name = "Aquidauana", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1496, Name = "Aral Moreira", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1497, Name = "Bandeirantes", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1498, Name = "Bataguassu", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1499, Name = "Bataiporã", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1500, Name = "Bela Vista", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1501, Name = "Bodoquena", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1502, Name = "Bonito", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1503, Name = "Brasilândia", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1504, Name = "Caarapó", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1505, Name = "Camapuã", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1506, Name = "Campo Grande", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1507, Name = "Caracol", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1508, Name = "Cassilândia", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1509, Name = "Chapadão do Sul", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1510, Name = "Corguinho", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1511, Name = "Coronel Sapucaia", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1512, Name = "Corumbá", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1513, Name = "Costa Rica", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1514, Name = "Coxim", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1515, Name = "Deodápolis", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1516, Name = "Dois Irmãos do Buriti", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1517, Name = "Douradina", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1518, Name = "Dourados", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1519, Name = "Eldorado", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1520, Name = "Fátima do Sul", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1521, Name = "Figueirão", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1522, Name = "Glória de Dourados", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1523, Name = "Guia Lopes da Laguna", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1524, Name = "Iguatemi", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1525, Name = "Inocência", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1526, Name = "Itaporã", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1527, Name = "Itaquiraí", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1528, Name = "Ivinhema", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1529, Name = "Japorã", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1530, Name = "Jaraguari", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1531, Name = "Jardim", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1532, Name = "Jateí", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1533, Name = "Juti", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1534, Name = "Ladário", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1535, Name = "Laguna Carapã", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1536, Name = "Maracaju", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1537, Name = "Miranda", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1538, Name = "Mundo Novo", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1539, Name = "Naviraí", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1540, Name = "Nioaque", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1541, Name = "Nova Alvorada do Sul", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1542, Name = "Nova Andradina", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1543, Name = "Novo Horizonte do Sul", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1544, Name = "Paranaíba", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1545, Name = "Paranhos", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1546, Name = "Pedro Gomes", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1547, Name = "Ponta Porã", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1548, Name = "Porto Murtinho", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1549, Name = "Ribas do Rio Pardo", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1550, Name = "Rio Brilhante", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1551, Name = "Rio Negro", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1552, Name = "Rio Verde de Mato Grosso", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1553, Name = "Rochedo", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1554, Name = "Santa Rita do Pardo", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1555, Name = "São Gabriel do Oeste", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1556, Name = "Selvíria", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1557, Name = "Sete Quedas", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1558, Name = "Sidrolândia", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1559, Name = "Sonora", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1560, Name = "Tacuru", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1561, Name = "Taquarussu", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1562, Name = "Terenos", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1563, Name = "Três Lagoas", IdState = 12 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1564, Name = "Vicentina", IdState = 12 });
        }
        private static void Cities13(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1346, Name = "Acorizal", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1347, Name = "Água Boa", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1348, Name = "Alta Floresta", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1349, Name = "Alto Araguaia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1350, Name = "Alto Boa Vista", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1351, Name = "Alto Garças", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1352, Name = "Alto Paraguai", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1353, Name = "Alto Taquari", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1354, Name = "Apiacás", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1355, Name = "Araguaiana", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1356, Name = "Araguainha", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1357, Name = "Araputanga", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1358, Name = "Arenápolis", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1359, Name = "Aripuanã", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1360, Name = "Barão de Melgaço", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1361, Name = "Barra do Bugres", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1362, Name = "Barra do Garças", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1363, Name = "Bom Jesus do Araguaia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1364, Name = "Brasnorte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1365, Name = "Cáceres", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1366, Name = "Campinápolis", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1367, Name = "Campo Novo do Parecis", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1368, Name = "Campo Verde", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1369, Name = "Campos de Júlio", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1370, Name = "Canabrava do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1371, Name = "Canarana", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1372, Name = "Carlinda", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1373, Name = "Castanheira", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1374, Name = "Chapada dos Guimarães", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1375, Name = "Cláudia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1376, Name = "Cocalinho", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1377, Name = "Colíder", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1378, Name = "Colniza", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1379, Name = "Comodoro", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1380, Name = "Confresa", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1381, Name = "Conquista d`Oeste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1382, Name = "Cotriguaçu", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1383, Name = "Cuiabá", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1384, Name = "Curvelândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1385, Name = "Curvelândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1386, Name = "Denise", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1387, Name = "Diamantino", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1388, Name = "Dom Aquino", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1389, Name = "Feliz Natal", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1390, Name = "Figueirópolis d`Oeste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1391, Name = "Gaúcha do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1392, Name = "General Carneiro", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1393, Name = "Glória d`Oeste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1394, Name = "Guarantã do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1395, Name = "Guiratinga", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1396, Name = "Indiavaí", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1397, Name = "Ipiranga do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1398, Name = "Itanhangá", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1399, Name = "Itaúba", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1400, Name = "Itiquira", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1401, Name = "Jaciara", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1402, Name = "Jangada", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1403, Name = "Jauru", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1404, Name = "Juara", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1405, Name = "Juína", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1406, Name = "Juruena", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1407, Name = "Juscimeira", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1408, Name = "Lambari d`Oeste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1409, Name = "Lucas do Rio Verde", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1410, Name = "Luciára", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1411, Name = "Marcelândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1412, Name = "Matupá", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1413, Name = "Mirassol d`Oeste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1414, Name = "Nobres", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1415, Name = "Nortelândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1416, Name = "Nossa Senhora do Livramento", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1417, Name = "Nova Bandeirantes", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1418, Name = "Nova Brasilândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1419, Name = "Nova Canaã do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1420, Name = "Nova Guarita", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1421, Name = "Nova Lacerda", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1422, Name = "Nova Marilândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1423, Name = "Nova Maringá", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1424, Name = "Nova Monte verde", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1425, Name = "Nova Mutum", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1426, Name = "Nova Olímpia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1427, Name = "Nova Santa Helena", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1428, Name = "Nova Ubiratã", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1429, Name = "Nova Xavantina", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1430, Name = "Novo Horizonte do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1431, Name = "Novo Mundo", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1432, Name = "Novo Santo Antônio", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1433, Name = "Novo São Joaquim", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1434, Name = "Paranaíta", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1435, Name = "Paranatinga", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1436, Name = "Pedra Preta", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1437, Name = "Peixoto de Azevedo", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1438, Name = "Planalto da Serra", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1439, Name = "Poconé", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1440, Name = "Pontal do Araguaia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1441, Name = "Ponte Branca", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1442, Name = "Pontes e Lacerda", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1443, Name = "Porto Alegre do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1444, Name = "Porto dos Gaúchos", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1445, Name = "Porto Esperidião", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1446, Name = "Porto Estrela", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1447, Name = "Poxoréo", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1448, Name = "Primavera do Leste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1449, Name = "Querência", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1450, Name = "Reserva do Cabaçal", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1451, Name = "Ribeirão Cascalheira", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1452, Name = "Ribeirãozinho", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1453, Name = "Rio Branco", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1454, Name = "Rondolândia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1455, Name = "Rondonópolis", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1456, Name = "Rosário Oeste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1457, Name = "Salto do Céu", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1458, Name = "Santa Carmem", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1459, Name = "Santa Cruz do Xingu", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1460, Name = "Santa Rita do Trivelato", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1461, Name = "Santa Terezinha", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1462, Name = "Santo Afonso", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1463, Name = "Santo Antônio do Leste", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1464, Name = "Santo Antônio do Leverger", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1465, Name = "São Félix do Araguaia", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1466, Name = "São José do Povo", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1467, Name = "São José do Rio Claro", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1468, Name = "São José do Xingu", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1469, Name = "São José dos Quatro Marcos", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1470, Name = "São Pedro da Cipa", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1471, Name = "Sapezal", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1472, Name = "Serra Nova Dourada", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1473, Name = "Sinop", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1474, Name = "Sorriso", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1475, Name = "Tabaporã", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1476, Name = "Tangará da Serra", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1477, Name = "Tapurah", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1478, Name = "Terra Nova do Norte", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1479, Name = "Tesouro", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1480, Name = "Torixoréu", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1481, Name = "União do Sul", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1482, Name = "Vale de São Domingos", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1483, Name = "Várzea Grande", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1484, Name = "Vera", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1485, Name = "Vila Bela da Santíssima Trindade", IdState = 13 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 1486, Name = "Vila Rica", IdState = 13 });
        }
        private static void Cities14(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2418, Name = "Abaetetuba", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2419, Name = "Abel Figueiredo", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2420, Name = "Acará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2421, Name = "Afuá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2422, Name = "Água Azul do Norte", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2423, Name = "Alenquer", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2424, Name = "Almeirim", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2425, Name = "Altamira", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2426, Name = "Anajás", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2427, Name = "Ananindeua", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2428, Name = "Anapu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2429, Name = "Augusto Corrêa", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2430, Name = "Aurora do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2431, Name = "Aveiro", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2432, Name = "Bagre", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2433, Name = "Baião", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2434, Name = "Bannach", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2435, Name = "Barcarena", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2436, Name = "Belém", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2437, Name = "Belterra", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2438, Name = "Benevides", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2439, Name = "Bom Jesus do Tocantins", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2440, Name = "Bonito", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2441, Name = "Bragança", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2442, Name = "Brasil Novo", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2443, Name = "Brejo Grande do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2444, Name = "Breu Branco", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2445, Name = "Breves", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2446, Name = "Bujaru", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2447, Name = "Cachoeira do Arari", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2448, Name = "Cachoeira do Piriá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2449, Name = "Cametá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2450, Name = "Canaã dos Carajás", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2451, Name = "Capanema", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2452, Name = "Capitão Poço", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2453, Name = "Castanhal", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2454, Name = "Chaves", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2455, Name = "Colares", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2456, Name = "Conceição do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2457, Name = "Concórdia do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2458, Name = "Cumaru do Norte", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2459, Name = "Curionópolis", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2460, Name = "Curralinho", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2461, Name = "Curuá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2462, Name = "Curuçá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2463, Name = "Dom Eliseu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2464, Name = "Eldorado dos Carajás", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2465, Name = "Faro", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2466, Name = "Floresta do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2467, Name = "Garrafão do Norte", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2468, Name = "Goianésia do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2469, Name = "Gurupá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2470, Name = "Igarapé-Açu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2471, Name = "Igarapé-Miri", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2472, Name = "Inhangapi", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2473, Name = "Ipixuna do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2474, Name = "Irituia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2475, Name = "Itaituba", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2476, Name = "Itupiranga", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2477, Name = "Jacareacanga", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2478, Name = "Jacundá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2479, Name = "Juruti", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2480, Name = "Limoeiro do Ajuru", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2481, Name = "Mãe do Rio", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2482, Name = "Magalhães Barata", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2483, Name = "Marabá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2484, Name = "Maracanã", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2485, Name = "Marapanim", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2486, Name = "Marituba", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2487, Name = "Medicilândia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2488, Name = "Melgaço", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2489, Name = "Mocajuba", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2490, Name = "Moju", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2491, Name = "Monte Alegre", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2492, Name = "Muaná", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2493, Name = "Nova Esperança do Piriá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2494, Name = "Nova Ipixuna", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2495, Name = "Nova Timboteua", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2496, Name = "Novo Progresso", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2497, Name = "Novo Repartimento", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2498, Name = "Óbidos", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2499, Name = "Oeiras do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2500, Name = "Oriximiná", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2501, Name = "Ourém", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2502, Name = "Ourilândia do Norte", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2503, Name = "Pacajá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2504, Name = "Palestina do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2505, Name = "Paragominas", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2506, Name = "Parauapebas", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2507, Name = "Pau d`Arco", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2508, Name = "Peixe-Boi", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2509, Name = "Piçarra", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2510, Name = "Placas", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2511, Name = "Ponta de Pedras", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2512, Name = "Portel", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2513, Name = "Porto de Moz", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2514, Name = "Prainha", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2515, Name = "Primavera", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2516, Name = "Quatipuru", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2517, Name = "Redenção", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2518, Name = "Rio Maria", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2519, Name = "Rondon do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2520, Name = "Rurópolis", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2521, Name = "Salinópolis", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2522, Name = "Salvaterra", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2523, Name = "Santa Bárbara do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2524, Name = "Santa Cruz do Arari", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2525, Name = "Santa Isabel do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2526, Name = "Santa Luzia do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2527, Name = "Santa Maria das Barreiras", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2528, Name = "Santa Maria do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2529, Name = "Santana do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2530, Name = "Santarém", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2531, Name = "Santarém Novo", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2532, Name = "Santo Antônio do Tauá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2533, Name = "São Caetano de Odivelas", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2534, Name = "São Domingos do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2535, Name = "São Domingos do Capim", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2536, Name = "São Félix do Xingu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2537, Name = "São Francisco do Pará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2538, Name = "São Geraldo do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2539, Name = "São João da Ponta", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2540, Name = "São João de Pirabas", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2541, Name = "São João do Araguaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2542, Name = "São Miguel do Guamá", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2543, Name = "São Sebastião da Boa Vista", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2544, Name = "Sapucaia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2545, Name = "Senador José Porfírio", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2546, Name = "Soure", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2547, Name = "Tailândia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2548, Name = "Terra Alta", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2549, Name = "Terra Santa", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2550, Name = "Tomé-Açu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2551, Name = "Tracuateua", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2552, Name = "Trairão", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2553, Name = "Tucumã", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2554, Name = "Tucuruí", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2555, Name = "Ulianópolis", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2556, Name = "Uruará", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2557, Name = "Vigia", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2558, Name = "Viseu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2559, Name = "Vitória do Xingu", IdState = 14 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2560, Name = "Xinguara", IdState = 14 });
        }
        private static void Cities15(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2561, Name = "Água Branca", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2562, Name = "Aguiar", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2563, Name = "Alagoa Grande", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2564, Name = "Alagoa Nova", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2565, Name = "Alagoinha", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2566, Name = "Alcantil", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2567, Name = "Algodão de Jandaíra", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2568, Name = "Alhandra", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2569, Name = "Amparo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2570, Name = "Aparecida", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2571, Name = "Araçagi", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2572, Name = "Arara", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2573, Name = "Araruna", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2574, Name = "Areia", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2575, Name = "Areia de Baraúnas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2576, Name = "Areial", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2577, Name = "Aroeiras", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2578, Name = "Assunção", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2579, Name = "Baía da Traição", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2580, Name = "Bananeiras", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2581, Name = "Baraúna", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2582, Name = "Barra de Santa Rosa", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2583, Name = "Barra de Santana", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2584, Name = "Barra de São Miguel", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2585, Name = "Bayeux", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2586, Name = "Belém", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2587, Name = "Belém do Brejo do Cruz", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2588, Name = "Bernardino Batista", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2589, Name = "Boa Ventura", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2590, Name = "Boa Vista", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2591, Name = "Bom Jesus", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2592, Name = "Bom Sucesso", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2593, Name = "Bonito de Santa Fé", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2594, Name = "Boqueirão", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2595, Name = "Borborema", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2596, Name = "Brejo do Cruz", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2597, Name = "Brejo dos Santos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2598, Name = "Caaporã", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2599, Name = "Cabaceiras", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2600, Name = "Cabedelo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2601, Name = "Cachoeira dos Índios", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2602, Name = "Cacimba de Areia", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2603, Name = "Cacimba de Dentro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2604, Name = "Cacimbas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2605, Name = "Caiçara", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2606, Name = "Cajazeiras", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2607, Name = "Cajazeirinhas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2608, Name = "Caldas Brandão", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2609, Name = "Camalaú", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2610, Name = "Campina Grande", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2611, Name = "Campo de Santana", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2612, Name = "Capim", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2613, Name = "Caraúbas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2614, Name = "Carrapateira", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2615, Name = "Casserengue", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2616, Name = "Catingueira", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2617, Name = "Catolé do Rocha", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2618, Name = "Caturité", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2619, Name = "Conceição", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2620, Name = "Condado", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2621, Name = "Conde", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2622, Name = "Congo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2623, Name = "Coremas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2624, Name = "Coxixola", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2625, Name = "Cruz do Espírito Santo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2626, Name = "Cubati", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2627, Name = "Cuité", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2628, Name = "Cuité de Mamanguape", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2629, Name = "Cuitegi", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2630, Name = "Curral de Cima", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2631, Name = "Curral Velho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2632, Name = "Damião", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2633, Name = "Desterro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2634, Name = "Diamante", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2635, Name = "Dona Inês", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2636, Name = "Duas Estradas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2637, Name = "Emas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2638, Name = "Esperança", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2639, Name = "Fagundes", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2640, Name = "Frei Martinho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2641, Name = "Gado Bravo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2642, Name = "Guarabira", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2643, Name = "Gurinhém", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2644, Name = "Gurjão", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2645, Name = "Ibiara", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2646, Name = "Igaracy", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2647, Name = "Imaculada", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2648, Name = "Ingá", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2649, Name = "Itabaiana", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2650, Name = "Itaporanga", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2651, Name = "Itapororoca", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2652, Name = "Itatuba", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2653, Name = "Jacaraú", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2654, Name = "Jericó", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2655, Name = "João Pessoa", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2656, Name = "Juarez Távora", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2657, Name = "Juazeirinho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2658, Name = "Junco do Seridó", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2659, Name = "Juripiranga", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2660, Name = "Juru", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2661, Name = "Lagoa", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2662, Name = "Lagoa de Dentro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2663, Name = "Lagoa Seca", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2664, Name = "Lastro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2665, Name = "Livramento", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2666, Name = "Logradouro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2667, Name = "Lucena", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2668, Name = "Mãe d`Água", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2669, Name = "Malta", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2670, Name = "Mamanguape", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2671, Name = "Manaíra", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2672, Name = "Marcação", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2673, Name = "Mari", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2674, Name = "Marizópolis", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2675, Name = "Massaranduba", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2676, Name = "Mataraca", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2677, Name = "Matinhas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2678, Name = "Mato Grosso", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2679, Name = "Maturéia", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2680, Name = "Mogeiro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2681, Name = "Montadas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2682, Name = "Monte Horebe", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2683, Name = "Monteiro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2684, Name = "Mulungu", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2685, Name = "Natuba", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2686, Name = "Nazarezinho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2687, Name = "Nova Floresta", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2688, Name = "Nova Olinda", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2689, Name = "Nova Palmeira", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2690, Name = "Olho d`Água", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2691, Name = "Olivedos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2692, Name = "Ouro Velho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2693, Name = "Parari", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2694, Name = "Passagem", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2695, Name = "Patos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2696, Name = "Paulista", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2697, Name = "Pedra Branca", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2698, Name = "Pedra Lavrada", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2699, Name = "Pedras de Fogo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2700, Name = "Pedro Régis", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2701, Name = "Piancó", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2702, Name = "Picuí", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2703, Name = "Pilar", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2704, Name = "Pilões", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2705, Name = "Pilõezinhos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2706, Name = "Pirpirituba", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2707, Name = "Pitimbu", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2708, Name = "Pocinhos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2709, Name = "Poço Dantas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2710, Name = "Poço de José de Moura", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2711, Name = "Pombal", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2712, Name = "Prata", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2713, Name = "Princesa Isabel", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2714, Name = "Puxinanã", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2715, Name = "Queimadas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2716, Name = "Quixabá", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2717, Name = "Remígio", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2718, Name = "Riachão", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2719, Name = "Riachão do Bacamarte", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2720, Name = "Riachão do Poço", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2721, Name = "Riacho de Santo Antônio", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2722, Name = "Riacho dos Cavalos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2723, Name = "Rio Tinto", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2724, Name = "Salgadinho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2725, Name = "Salgado de São Félix", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2726, Name = "Santa Cecília", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2727, Name = "Santa Cruz", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2728, Name = "Santa Helena", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2729, Name = "Santa Inês", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2730, Name = "Santa Luzia", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2731, Name = "Santa Rita", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2732, Name = "Santa Teresinha", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2733, Name = "Santana de Mangueira", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2734, Name = "Santana dos Garrotes", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2735, Name = "Santarém", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2736, Name = "Santo André", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2737, Name = "São Bentinho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2738, Name = "São Bento", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2739, Name = "São Domingos de Pombal", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2740, Name = "São Domingos do Cariri", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2741, Name = "São Francisco", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2742, Name = "São João do Cariri", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2743, Name = "São João do Rio do Peixe", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2744, Name = "São João do Tigre", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2745, Name = "São José da Lagoa Tapada", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2746, Name = "São José de Caiana", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2747, Name = "São José de Espinharas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2748, Name = "São José de Piranhas", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2749, Name = "São José de Princesa", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2750, Name = "São José do Bonfim", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2751, Name = "São José do Brejo do Cruz", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2752, Name = "São José do Sabugi", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2753, Name = "São José dos Cordeiros", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2754, Name = "São José dos Ramos", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2755, Name = "São Mamede", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2756, Name = "São Miguel de Taipu", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2757, Name = "São Sebastião de Lagoa de Roça", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2758, Name = "São Sebastião do Umbuzeiro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2759, Name = "Sapé", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2760, Name = "Seridó", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2761, Name = "Serra Branca", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2762, Name = "Serra da Raiz", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2763, Name = "Serra Grande", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2764, Name = "Serra Redonda", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2765, Name = "Serraria", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2766, Name = "Sertãozinho", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2767, Name = "Sobrado", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2768, Name = "Solânea", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2769, Name = "Soledade", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2770, Name = "Sossêgo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2771, Name = "Sousa", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2772, Name = "Sumé", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2773, Name = "Taperoá", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2774, Name = "Tavares", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2775, Name = "Teixeira", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2776, Name = "Tenório", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2777, Name = "Triunfo", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2778, Name = "Uiraúna", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2779, Name = "Umbuzeiro", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2780, Name = "Várzea", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2781, Name = "Vieirópolis", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2782, Name = "Vista Serrana", IdState = 15 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2783, Name = "Zabelê", IdState = 15 });
        }
        private static void Cities16(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3183, Name = "Abreu e Lima", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3184, Name = "Afogados da Ingazeira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3185, Name = "Afrânio", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3186, Name = "Agrestina", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3187, Name = "Água Preta", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3188, Name = "Águas Belas", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3189, Name = "Alagoinha", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3190, Name = "Aliança", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3191, Name = "Altinho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3192, Name = "Amaraji", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3193, Name = "Angelim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3194, Name = "Araçoiaba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3195, Name = "Araripina", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3196, Name = "Arcoverde", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3197, Name = "Barra de Guabiraba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3198, Name = "Barreiros", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3199, Name = "Belém de Maria", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3200, Name = "Belém de São Francisco", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3201, Name = "Belo Jardim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3202, Name = "Betânia", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3203, Name = "Bezerros", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3204, Name = "Bodocó", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3205, Name = "Bom Conselho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3206, Name = "Bom Jardim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3207, Name = "Bonito", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3208, Name = "Brejão", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3209, Name = "Brejinho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3210, Name = "Brejo da Madre de Deus", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3211, Name = "Buenos Aires", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3212, Name = "Buíque", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3213, Name = "Cabo de Santo Agostinho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3214, Name = "Cabrobó", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3215, Name = "Cachoeirinha", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3216, Name = "Caetés", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3217, Name = "Calçado", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3218, Name = "Calumbi", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3219, Name = "Camaragibe", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3220, Name = "Camocim de São Félix", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3221, Name = "Camutanga", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3222, Name = "Canhotinho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3223, Name = "Capoeiras", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3224, Name = "Carnaíba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3225, Name = "Carnaubeira da Penha", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3226, Name = "Carpina", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3227, Name = "Caruaru", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3228, Name = "Casinhas", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3229, Name = "Catende", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3230, Name = "Cedro", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3231, Name = "Chã de Alegria", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3232, Name = "Chã Grande", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3233, Name = "Condado", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3234, Name = "Correntes", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3235, Name = "Cortês", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3236, Name = "Cumaru", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3237, Name = "Cupira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3238, Name = "Custódia", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3239, Name = "Dormentes", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3240, Name = "Escada", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3241, Name = "Exu", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3242, Name = "Feira Nova", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3243, Name = "Fernando de Noronha", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3244, Name = "Ferreiros", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3245, Name = "Flores", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3246, Name = "Floresta", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3247, Name = "Frei Miguelinho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3248, Name = "Gameleira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3249, Name = "Garanhuns", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3250, Name = "Glória do Goitá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3251, Name = "Goiana", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3252, Name = "Granito", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3253, Name = "Gravatá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3254, Name = "Iati", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3255, Name = "Ibimirim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3256, Name = "Ibirajuba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3257, Name = "Igarassu", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3258, Name = "Iguaraci", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3259, Name = "Ilha de Itamaracá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3260, Name = "Inajá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3261, Name = "Ingazeira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3262, Name = "Ipojuca", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3263, Name = "Ipubi", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3264, Name = "Itacuruba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3265, Name = "Itaíba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3266, Name = "Itambé", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3267, Name = "Itapetim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3268, Name = "Itapissuma", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3269, Name = "Itaquitinga", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3270, Name = "Jaboatão dos Guararapes", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3271, Name = "Jaqueira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3272, Name = "Jataúba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3273, Name = "Jatobá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3274, Name = "João Alfredo", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3275, Name = "Joaquim Nabuco", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3276, Name = "Jucati", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3277, Name = "Jupi", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3278, Name = "Jurema", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3279, Name = "Lagoa do Carro", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3280, Name = "Lagoa do Itaenga", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3281, Name = "Lagoa do Ouro", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3282, Name = "Lagoa dos Gatos", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3283, Name = "Lagoa Grande", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3284, Name = "Lajedo", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3285, Name = "Limoeiro", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3286, Name = "Macaparana", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3287, Name = "Machados", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3288, Name = "Manari", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3289, Name = "Maraial", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3290, Name = "Mirandiba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3291, Name = "Moreilândia", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3292, Name = "Moreno", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3293, Name = "Nazaré da Mata", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3294, Name = "Olinda", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3295, Name = "Orobó", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3296, Name = "Orocó", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3297, Name = "Ouricuri", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3298, Name = "Palmares", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3299, Name = "Palmeirina", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3300, Name = "Panelas", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3301, Name = "Paranatama", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3302, Name = "Parnamirim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3303, Name = "Passira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3304, Name = "Paudalho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3305, Name = "Paulista", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3306, Name = "Pedra", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3307, Name = "Pesqueira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3308, Name = "Petrolândia", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3309, Name = "Petrolina", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3310, Name = "Poção", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3311, Name = "Pombos", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3312, Name = "Primavera", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3313, Name = "Quipapá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3314, Name = "Quixaba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3315, Name = "Recife", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3316, Name = "Riacho das Almas", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3317, Name = "Ribeirão", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3318, Name = "Rio Formoso", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3319, Name = "Sairé", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3320, Name = "Salgadinho", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3321, Name = "Salgueiro", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3322, Name = "Saloá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3323, Name = "Sanharó", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3324, Name = "Santa Cruz", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3325, Name = "Santa Cruz da Baixa Verde", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3326, Name = "Santa Cruz do Capibaribe", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3327, Name = "Santa Filomena", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3328, Name = "Santa Maria da Boa Vista", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3329, Name = "Santa Maria do Cambucá", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3330, Name = "Santa Terezinha", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3331, Name = "São Benedito do Sul", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3332, Name = "São Bento do Una", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3333, Name = "São Caitano", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3334, Name = "São João", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3335, Name = "São Joaquim do Monte", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3336, Name = "São José da Coroa Grande", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3337, Name = "São José do Belmonte", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3338, Name = "São José do Egito", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3339, Name = "São Lourenço da Mata", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3340, Name = "São Vicente Ferrer", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3341, Name = "Serra Talhada", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3342, Name = "Serrita", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3343, Name = "Sertânia", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3344, Name = "Sirinhaém", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3345, Name = "Solidão", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3346, Name = "Surubim", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3347, Name = "Tabira", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3348, Name = "Tacaimbó", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3349, Name = "Tacaratu", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3350, Name = "Tamandaré", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3351, Name = "Taquaritinga do Norte", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3352, Name = "Terezinha", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3353, Name = "Terra Nova", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3354, Name = "Timbaúba", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3355, Name = "Toritama", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3356, Name = "Tracunhaém", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3357, Name = "Trindade", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3358, Name = "Triunfo", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3359, Name = "Tupanatinga", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3360, Name = "Tuparetama", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3361, Name = "Venturosa", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3362, Name = "Verdejante", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3363, Name = "Vertente do Lério", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3364, Name = "Vertentes", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3365, Name = "Vicência", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3366, Name = "Vitória de Santo Antão", IdState = 16 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3367, Name = "Xexéu", IdState = 16 });
        }
        private static void Cities17(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3368, Name = "Acauã", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3369, Name = "Agricolândia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3370, Name = "Água Branca", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3371, Name = "Alagoinha do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3372, Name = "Alegrete do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3373, Name = "Alto Longá", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3374, Name = "Altos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3375, Name = "Alvorada do Gurguéia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3376, Name = "Amarante", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3377, Name = "Angical do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3378, Name = "Anísio de Abreu", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3379, Name = "Antônio Almeida", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3380, Name = "Aroazes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3381, Name = "Aroeiras do Itaim", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3382, Name = "Arraial", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3383, Name = "Assunção do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3384, Name = "Avelino Lopes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3385, Name = "Baixa Grande do Ribeiro", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3386, Name = "Barra d`Alcântara", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3387, Name = "Barras", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3388, Name = "Barreiras do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3389, Name = "Barro Duro", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3390, Name = "Batalha", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3391, Name = "Bela Vista do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3392, Name = "Belém do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3393, Name = "Beneditinos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3394, Name = "Bertolínia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3395, Name = "Betânia do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3396, Name = "Boa Hora", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3397, Name = "Bocaina", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3398, Name = "Bom Jesus", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3399, Name = "Bom Princípio do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3400, Name = "Bonfim do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3401, Name = "Boqueirão do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3402, Name = "Brasileira", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3403, Name = "Brejo do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3404, Name = "Buriti dos Lopes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3405, Name = "Buriti dos Montes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3406, Name = "Cabeceiras do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3407, Name = "Cajazeiras do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3408, Name = "Cajueiro da Praia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3409, Name = "Caldeirão Grande do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3410, Name = "Campinas do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3411, Name = "Campo Alegre do Fidalgo", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3412, Name = "Campo Grande do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3413, Name = "Campo Largo do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3414, Name = "Campo Maior", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3415, Name = "Canavieira", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3416, Name = "Canto do Buriti", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3417, Name = "Capitão de Campos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3418, Name = "Capitão Gervásio Oliveira", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3419, Name = "Caracol", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3420, Name = "Caraúbas do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3421, Name = "Caridade do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3422, Name = "Castelo do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3423, Name = "Caxingó", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3424, Name = "Cocal", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3425, Name = "Cocal de Telha", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3426, Name = "Cocal dos Alves", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3427, Name = "Coivaras", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3428, Name = "Colônia do Gurguéia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3429, Name = "Colônia do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3430, Name = "Conceição do Canindé", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3431, Name = "Coronel José Dias", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3432, Name = "Corrente", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3433, Name = "Cristalândia do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3434, Name = "Cristino Castro", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3435, Name = "Curimatá", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3436, Name = "Currais", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3437, Name = "Curral Novo do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3438, Name = "Curralinhos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3439, Name = "Demerval Lobão", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3440, Name = "Dirceu Arcoverde", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3441, Name = "Dom Expedito Lopes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3442, Name = "Dom Inocêncio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3443, Name = "Domingos Mourão", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3444, Name = "Elesbão Veloso", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3445, Name = "Eliseu Martins", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3446, Name = "Esperantina", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3447, Name = "Fartura do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3448, Name = "Flores do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3449, Name = "Floresta do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3450, Name = "Floriano", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3451, Name = "Francinópolis", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3452, Name = "Francisco Ayres", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3453, Name = "Francisco Macedo", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3454, Name = "Francisco Santos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3455, Name = "Fronteiras", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3456, Name = "Geminiano", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3457, Name = "Gilbués", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3458, Name = "Guadalupe", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3459, Name = "Guaribas", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3460, Name = "Hugo Napoleão", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3461, Name = "Ilha Grande", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3462, Name = "Inhuma", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3463, Name = "Ipiranga do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3464, Name = "Isaías Coelho", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3465, Name = "Itainópolis", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3466, Name = "Itaueira", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3467, Name = "Jacobina do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3468, Name = "Jaicós", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3469, Name = "Jardim do Mulato", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3470, Name = "Jatobá do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3471, Name = "Jerumenha", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3472, Name = "João Costa", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3473, Name = "Joaquim Pires", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3474, Name = "Joca Marques", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3475, Name = "José de Freitas", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3476, Name = "Juazeiro do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3477, Name = "Júlio Borges", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3478, Name = "Jurema", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3479, Name = "Lagoa Alegre", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3480, Name = "Lagoa de São Francisco", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3481, Name = "Lagoa do Barro do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3482, Name = "Lagoa do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3483, Name = "Lagoa do Sítio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3484, Name = "Lagoinha do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3485, Name = "Landri Sales", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3486, Name = "Luís Correia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3487, Name = "Luzilândia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3488, Name = "Madeiro", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3489, Name = "Manoel Emídio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3490, Name = "Marcolândia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3491, Name = "Marcos Parente", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3492, Name = "Massapê do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3493, Name = "Matias Olímpio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3494, Name = "Miguel Alves", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3495, Name = "Miguel Leão", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3496, Name = "Milton Brandão", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3497, Name = "Monsenhor Gil", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3498, Name = "Monsenhor Hipólito", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3499, Name = "Monte Alegre do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3500, Name = "Morro Cabeça no Tempo", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3501, Name = "Morro do Chapéu do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3502, Name = "Murici dos Portelas", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3503, Name = "Nazaré do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3504, Name = "Nossa Senhora de Nazaré", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3505, Name = "Nossa Senhora dos Remédios", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3506, Name = "Nova Santa Rita", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3507, Name = "Novo Oriente do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3508, Name = "Novo Santo Antônio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3509, Name = "Oeiras", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3510, Name = "Olho d`Água do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3511, Name = "Padre Marcos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3512, Name = "Paes Landim", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3513, Name = "Pajeú do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3514, Name = "Palmeira do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3515, Name = "Palmeirais", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3516, Name = "Paquetá", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3517, Name = "Parnaguá", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3518, Name = "Parnaíba", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3519, Name = "Passagem Franca do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3520, Name = "Patos do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3521, Name = "Pau d`Arco do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3522, Name = "Paulistana", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3523, Name = "Pavussu", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3524, Name = "Pedro II", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3525, Name = "Pedro Laurentino", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3526, Name = "Picos", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3527, Name = "Pimenteiras", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3528, Name = "Pio IX", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3529, Name = "Piracuruca", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3530, Name = "Piripiri", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3531, Name = "Porto", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3532, Name = "Porto Alegre do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3533, Name = "Prata do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3534, Name = "Queimada Nova", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3535, Name = "Redenção do Gurguéia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3536, Name = "Regeneração", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3537, Name = "Riacho Frio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3538, Name = "Ribeira do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3539, Name = "Ribeiro Gonçalves", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3540, Name = "Rio Grande do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3541, Name = "Santa Cruz do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3542, Name = "Santa Cruz dos Milagres", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3543, Name = "Santa Filomena", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3544, Name = "Santa Luz", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3545, Name = "Santa Rosa do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3546, Name = "Santana do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3547, Name = "Santo Antônio de Lisboa", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3548, Name = "Santo Antônio dos Milagres", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3549, Name = "Santo Inácio do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3550, Name = "São Braz do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3551, Name = "São Félix do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3552, Name = "São Francisco de Assis do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3553, Name = "São Francisco do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3554, Name = "São Gonçalo do Gurguéia", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3555, Name = "São Gonçalo do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3556, Name = "São João da Canabrava", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3557, Name = "São João da Fronteira", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3558, Name = "São João da Serra", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3559, Name = "São João da Varjota", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3560, Name = "São João do Arraial", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3561, Name = "São João do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3562, Name = "São José do Divino", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3563, Name = "São José do Peixe", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3564, Name = "São José do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3565, Name = "São Julião", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3566, Name = "São Lourenço do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3567, Name = "São Luis do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3568, Name = "São Miguel da Baixa Grande", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3569, Name = "São Miguel do Fidalgo", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3570, Name = "São Miguel do Tapuio", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3571, Name = "São Pedro do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3572, Name = "São Raimundo Nonato", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3573, Name = "Sebastião Barros", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3574, Name = "Sebastião Leal", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3575, Name = "Sigefredo Pacheco", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3576, Name = "Simões", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3577, Name = "Simplício Mendes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3578, Name = "Socorro do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3579, Name = "Sussuapara", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3580, Name = "Tamboril do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3581, Name = "Tanque do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3582, Name = "Teresina", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3583, Name = "União", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3584, Name = "Uruçuí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3585, Name = "Valença do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3586, Name = "Várzea Branca", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3587, Name = "Várzea Grande", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3588, Name = "Vera Mendes", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3589, Name = "Vila Nova do Piauí", IdState = 17 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3590, Name = "Wall Ferraz", IdState = 17 });
        }
        private static void Cities18(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2784, Name = "Abatiá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2785, Name = "Adrianópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2786, Name = "Agudos do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2787, Name = "Almirante Tamandaré", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2788, Name = "Altamira do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2789, Name = "Alto Paraíso", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2790, Name = "Alto Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2791, Name = "Alto Piquiri", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2792, Name = "Altônia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2793, Name = "Alvorada do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2794, Name = "Amaporã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2795, Name = "Ampére", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2796, Name = "Anahy", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2797, Name = "Andirá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2798, Name = "Ângulo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2799, Name = "Antonina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2800, Name = "Antônio Olinto", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2801, Name = "Apucarana", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2802, Name = "Arapongas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2803, Name = "Arapoti", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2804, Name = "Arapuã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2805, Name = "Araruna", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2806, Name = "Araucária", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2807, Name = "Ariranha do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2808, Name = "Assaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2809, Name = "Assis Chateaubriand", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2810, Name = "Astorga", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2811, Name = "Atalaia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2812, Name = "Balsa Nova", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2813, Name = "Bandeirantes", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2814, Name = "Barbosa Ferraz", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2815, Name = "Barra do Jacaré", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2816, Name = "Barracão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2817, Name = "Bela Vista da Caroba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2818, Name = "Bela Vista do Paraíso", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2819, Name = "Bituruna", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2820, Name = "Boa Esperança", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2821, Name = "Boa Esperança do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2822, Name = "Boa Ventura de São Roque", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2823, Name = "Boa Vista da Aparecida", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2824, Name = "Bocaiúva do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2825, Name = "Bom Jesus do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2826, Name = "Bom Sucesso", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2827, Name = "Bom Sucesso do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2828, Name = "Borrazópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2829, Name = "Braganey", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2830, Name = "Brasilândia do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2831, Name = "Cafeara", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2832, Name = "Cafelândia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2833, Name = "Cafezal do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2834, Name = "Califórnia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2835, Name = "Cambará", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2836, Name = "Cambé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2837, Name = "Cambira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2838, Name = "Campina da Lagoa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2839, Name = "Campina do Simão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2840, Name = "Campina Grande do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2841, Name = "Campo Bonito", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2842, Name = "Campo do Tenente", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2843, Name = "Campo Largo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2844, Name = "Campo Magro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2845, Name = "Campo Mourão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2846, Name = "Cândido de Abreu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2847, Name = "Candói", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2848, Name = "Cantagalo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2849, Name = "Capanema", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2850, Name = "Capitão Leônidas Marques", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2851, Name = "Carambeí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2852, Name = "Carlópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2853, Name = "Cascavel", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2854, Name = "Castro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2855, Name = "Catanduvas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2856, Name = "Centenário do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2857, Name = "Cerro Azul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2858, Name = "Céu Azul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2859, Name = "Chopinzinho", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2860, Name = "Cianorte", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2861, Name = "Cidade Gaúcha", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2862, Name = "Clevelândia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2863, Name = "Colombo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2864, Name = "Colorado", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2865, Name = "Congonhinhas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2866, Name = "Conselheiro Mairinck", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2867, Name = "Contenda", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2868, Name = "Corbélia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2869, Name = "Cornélio Procópio", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2870, Name = "Coronel Domingos Soares", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2871, Name = "Coronel Vivida", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2872, Name = "Corumbataí do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2873, Name = "Cruz Machado", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2874, Name = "Cruzeiro do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2875, Name = "Cruzeiro do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2876, Name = "Cruzeiro do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2877, Name = "Cruzmaltina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2878, Name = "Curitiba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2879, Name = "Curiúva", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2880, Name = "Diamante d`Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2881, Name = "Diamante do Norte", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2882, Name = "Diamante do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2883, Name = "Dois Vizinhos", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2884, Name = "Douradina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2885, Name = "Doutor Camargo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2886, Name = "Doutor Ulysses", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2887, Name = "Enéas Marques", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2888, Name = "Engenheiro Beltrão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2889, Name = "Entre Rios do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2890, Name = "Esperança Nova", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2891, Name = "Espigão Alto do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2892, Name = "Farol", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2893, Name = "Faxinal", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2894, Name = "Fazenda Rio Grande", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2895, Name = "Fênix", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2896, Name = "Fernandes Pinheiro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2897, Name = "Figueira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2898, Name = "Flor da Serra do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2899, Name = "Floraí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2900, Name = "Floresta", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2901, Name = "Florestópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2902, Name = "Flórida", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2903, Name = "Formosa do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2904, Name = "Foz do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2905, Name = "Foz do Jordão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2906, Name = "Francisco Alves", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2907, Name = "Francisco Beltrão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2908, Name = "General Carneiro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2909, Name = "Godoy Moreira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2910, Name = "Goioerê", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2911, Name = "Goioxim", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2912, Name = "Grandes Rios", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2913, Name = "Guaíra", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2914, Name = "Guairaçá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2915, Name = "Guamiranga", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2916, Name = "Guapirama", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2917, Name = "Guaporema", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2918, Name = "Guaraci", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2919, Name = "Guaraniaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2920, Name = "Guarapuava", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2921, Name = "Guaraqueçaba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2922, Name = "Guaratuba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2923, Name = "Honório Serpa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2924, Name = "Ibaiti", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2925, Name = "Ibema", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2926, Name = "Ibiporã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2927, Name = "Icaraíma", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2928, Name = "Iguaraçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2929, Name = "Iguatu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2930, Name = "Imbaú", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2931, Name = "Imbituva", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2932, Name = "Inácio Martins", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2933, Name = "Inajá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2934, Name = "Indianópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2935, Name = "Ipiranga", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2936, Name = "Iporã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2937, Name = "Iracema do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2938, Name = "Irati", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2939, Name = "Iretama", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2940, Name = "Itaguajé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2941, Name = "Itaipulândia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2942, Name = "Itambaracá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2943, Name = "Itambé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2944, Name = "Itapejara d`Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2945, Name = "Itaperuçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2946, Name = "Itaúna do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2947, Name = "Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2948, Name = "Ivaiporã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2949, Name = "Ivaté", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2950, Name = "Ivatuba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2951, Name = "Jaboti", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2952, Name = "Jacarezinho", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2953, Name = "Jaguapitã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2954, Name = "Jaguariaíva", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2955, Name = "Jandaia do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2956, Name = "Janiópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2957, Name = "Japira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2958, Name = "Japurá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2959, Name = "Jardim Alegre", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2960, Name = "Jardim Olinda", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2961, Name = "Jataizinho", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2962, Name = "Jesuítas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2963, Name = "Joaquim Távora", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2964, Name = "Jundiaí do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2965, Name = "Juranda", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2966, Name = "Jussara", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2967, Name = "Kaloré", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2968, Name = "Lapa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2969, Name = "Laranjal", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2970, Name = "Laranjeiras do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2971, Name = "Leópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2972, Name = "Lidianópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2973, Name = "Lindoeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2974, Name = "Loanda", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2975, Name = "Lobato", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2976, Name = "Londrina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2977, Name = "Luiziana", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2978, Name = "Lunardelli", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2979, Name = "Lupionópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2980, Name = "Mallet", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2981, Name = "Mamborê", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2982, Name = "Mandaguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2983, Name = "Mandaguari", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2984, Name = "Mandirituba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2985, Name = "Manfrinópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2986, Name = "Mangueirinha", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2987, Name = "Manoel Ribas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2988, Name = "Marechal Cândido Rondon", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2989, Name = "Maria Helena", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2990, Name = "Marialva", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2991, Name = "Marilândia do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2992, Name = "Marilena", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2993, Name = "Mariluz", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2994, Name = "Maringá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2995, Name = "Mariópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2996, Name = "Maripá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2997, Name = "Marmeleiro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2998, Name = "Marquinho", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 2999, Name = "Marumbi", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3000, Name = "Matelândia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3001, Name = "Matinhos", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3002, Name = "Mato Rico", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3003, Name = "Mauá da Serra", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3004, Name = "Medianeira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3005, Name = "Mercedes", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3006, Name = "Mirador", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3007, Name = "Miraselva", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3008, Name = "Missal", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3009, Name = "Moreira Sales", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3010, Name = "Morretes", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3011, Name = "Munhoz de Melo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3012, Name = "Nossa Senhora das Graças", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3013, Name = "Nova Aliança do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3014, Name = "Nova América da Colina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3015, Name = "Nova Aurora", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3016, Name = "Nova Cantu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3017, Name = "Nova Esperança", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3018, Name = "Nova Esperança do Sudoeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3019, Name = "Nova Fátima", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3020, Name = "Nova Laranjeiras", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3021, Name = "Nova Londrina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3022, Name = "Nova Olímpia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3023, Name = "Nova Prata do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3024, Name = "Nova Santa Bárbara", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3025, Name = "Nova Santa Rosa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3026, Name = "Nova Tebas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3027, Name = "Novo Itacolomi", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3028, Name = "Ortigueira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3029, Name = "Ourizona", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3030, Name = "Ouro Verde do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3031, Name = "Paiçandu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3032, Name = "Palmas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3033, Name = "Palmeira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3034, Name = "Palmital", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3035, Name = "Palotina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3036, Name = "Paraíso do Norte", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3037, Name = "Paranacity", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3038, Name = "Paranaguá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3039, Name = "Paranapoema", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3040, Name = "Paranavaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3041, Name = "Pato Bragado", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3042, Name = "Pato Branco", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3043, Name = "Paula Freitas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3044, Name = "Paulo Frontin", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3045, Name = "Peabiru", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3046, Name = "Perobal", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3047, Name = "Pérola", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3048, Name = "Pérola d`Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3049, Name = "Piên", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3050, Name = "Pinhais", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3051, Name = "Pinhal de São Bento", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3052, Name = "Pinhalão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3053, Name = "Pinhão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3054, Name = "Piraí do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3055, Name = "Piraquara", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3056, Name = "Pitanga", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3057, Name = "Pitangueiras", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3058, Name = "Planaltina do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3059, Name = "Planalto", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3060, Name = "Ponta Grossa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3061, Name = "Pontal do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3062, Name = "Porecatu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3063, Name = "Porto Amazonas", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3064, Name = "Porto Barreiro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3065, Name = "Porto Rico", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3066, Name = "Porto Vitória", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3067, Name = "Prado Ferreira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3068, Name = "Pranchita", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3069, Name = "Presidente Castelo Branco", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3070, Name = "Primeiro de Maio", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3071, Name = "Prudentópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3072, Name = "Quarto Centenário", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3073, Name = "Quatiguá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3074, Name = "Quatro Barras", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3075, Name = "Quatro Pontes", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3076, Name = "Quedas do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3077, Name = "Querência do Norte", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3078, Name = "Quinta do Sol", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3079, Name = "Quitandinha", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3080, Name = "Ramilândia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3081, Name = "Rancho Alegre", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3082, Name = "Rancho Alegre d`Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3083, Name = "Realeza", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3084, Name = "Rebouças", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3085, Name = "Renascença", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3086, Name = "Reserva", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3087, Name = "Reserva do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3088, Name = "Ribeirão Claro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3089, Name = "Ribeirão do Pinhal", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3090, Name = "Rio Azul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3091, Name = "Rio Bom", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3092, Name = "Rio Bonito do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3093, Name = "Rio Branco do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3094, Name = "Rio Branco do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3095, Name = "Rio Negro", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3096, Name = "Rolândia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3097, Name = "Roncador", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3098, Name = "Rondon", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3099, Name = "Rosário do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3100, Name = "Sabáudia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3101, Name = "Salgado Filho", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3102, Name = "Salto do Itararé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3103, Name = "Salto do Lontra", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3104, Name = "Santa Amélia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3105, Name = "Santa Cecília do Pavão", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3106, Name = "Santa Cruz de Monte Castelo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3107, Name = "Santa Fé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3108, Name = "Santa Helena", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3109, Name = "Santa Inês", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3110, Name = "Santa Isabel do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3111, Name = "Santa Izabel do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3112, Name = "Santa Lúcia", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3113, Name = "Santa Maria do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3114, Name = "Santa Mariana", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3115, Name = "Santa Mônica", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3116, Name = "Santa Tereza do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3117, Name = "Santa Terezinha de Itaipu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3118, Name = "Santana do Itararé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3119, Name = "Santo Antônio da Platina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3120, Name = "Santo Antônio do Caiuá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3121, Name = "Santo Antônio do Paraíso", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3122, Name = "Santo Antônio do Sudoeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3123, Name = "Santo Inácio", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3124, Name = "São Carlos do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3125, Name = "São Jerônimo da Serra", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3126, Name = "São João", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3127, Name = "São João do Caiuá", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3128, Name = "São João do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3129, Name = "São João do Triunfo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3130, Name = "São Jorge d`Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3131, Name = "São Jorge do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3132, Name = "São Jorge do Patrocínio", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3133, Name = "São José da Boa Vista", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3134, Name = "São José das Palmeiras", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3135, Name = "São José dos Pinhais", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3136, Name = "São Manoel do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3137, Name = "São Mateus do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3138, Name = "São Miguel do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3139, Name = "São Pedro do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3140, Name = "São Pedro do Ivaí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3141, Name = "São Pedro do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3142, Name = "São Sebastião da Amoreira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3143, Name = "São Tomé", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3144, Name = "Sapopema", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3145, Name = "Sarandi", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3146, Name = "Saudade do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3147, Name = "Sengés", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3148, Name = "Serranópolis do Iguaçu", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3149, Name = "Sertaneja", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3150, Name = "Sertanópolis", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3151, Name = "Siqueira Campos", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3152, Name = "Sulina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3153, Name = "Tamarana", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3154, Name = "Tamboara", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3155, Name = "Tapejara", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3156, Name = "Tapira", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3157, Name = "Teixeira Soares", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3158, Name = "Telêmaco Borba", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3159, Name = "Terra Boa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3160, Name = "Terra Rica", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3161, Name = "Terra Roxa", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3162, Name = "Tibagi", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3163, Name = "Tijucas do Sul", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3164, Name = "Toledo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3165, Name = "Tomazina", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3166, Name = "Três Barras do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3167, Name = "Tunas do Paraná", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3168, Name = "Tuneiras do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3169, Name = "Tupãssi", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3170, Name = "Turvo", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3171, Name = "Ubiratã", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3172, Name = "Umuarama", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3173, Name = "União da Vitória", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3174, Name = "Uniflor", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3175, Name = "Uraí", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3176, Name = "Ventania", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3177, Name = "Vera Cruz do Oeste", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3178, Name = "Verê", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3179, Name = "Virmond", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3180, Name = "Vitorino", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3181, Name = "Wenceslau Braz", IdState = 18 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3182, Name = "Xambrê", IdState = 18 });
        }
        private static void Cities19(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3591, Name = "Angra dos Reis", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3592, Name = "Aperibé", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3593, Name = "Araruama", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3594, Name = "Areal", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3595, Name = "Armação dos Búzios", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3596, Name = "Arraial do Cabo", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3597, Name = "Barra do Piraí", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3598, Name = "Barra Mansa", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3599, Name = "Belford Roxo", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3600, Name = "Bom Jardim", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3601, Name = "Bom Jesus do Itabapoana", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3602, Name = "Cabo Frio", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3603, Name = "Cachoeiras de Macacu", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3604, Name = "Cambuci", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3605, Name = "Campos dos Goytacazes", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3606, Name = "Cantagalo", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3607, Name = "Carapebus", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3608, Name = "Cardoso Moreira", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3609, Name = "Carmo", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3610, Name = "Casimiro de Abreu", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3611, Name = "Comendador Levy Gasparian", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3612, Name = "Conceição de Macabu", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3613, Name = "Cordeiro", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3614, Name = "Duas Barras", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3615, Name = "Duque de Caxias", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3616, Name = "Engenheiro Paulo de Frontin", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3617, Name = "Guapimirim", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3618, Name = "Iguaba Grande", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3619, Name = "Itaboraí", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3620, Name = "Itaguaí", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3621, Name = "Italva", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3622, Name = "Itaocara", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3623, Name = "Itaperuna", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3624, Name = "Itatiaia", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3625, Name = "Japeri", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3626, Name = "Laje do Muriaé", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3627, Name = "Macaé", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3628, Name = "Macuco", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3629, Name = "Magé", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3630, Name = "Mangaratiba", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3631, Name = "Maricá", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3632, Name = "Mendes", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3633, Name = "Mesquita", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3634, Name = "Miguel Pereira", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3635, Name = "Miracema", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3636, Name = "Natividade", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3637, Name = "Nilópolis", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3638, Name = "Niterói", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3639, Name = "Nova Friburgo", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3640, Name = "Nova Iguaçu", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3641, Name = "Paracambi", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3642, Name = "Paraíba do Sul", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3643, Name = "Parati", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3644, Name = "Paty do Alferes", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3645, Name = "Petrópolis", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3646, Name = "Pinheiral", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3647, Name = "Piraí", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3648, Name = "Porciúncula", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3649, Name = "Porto Real", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3650, Name = "Quatis", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3651, Name = "Queimados", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3652, Name = "Quissamã", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3653, Name = "Resende", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3654, Name = "Rio Bonito", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3655, Name = "Rio Claro", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3656, Name = "Rio das Flores", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3657, Name = "Rio das Ostras", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3658, Name = "Rio de Janeiro", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3659, Name = "Santa Maria Madalena", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3660, Name = "Santo Antônio de Pádua", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3661, Name = "São Fidélis", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3662, Name = "São Francisco de Itabapoana", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3663, Name = "São Gonçalo", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3664, Name = "São João da Barra", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3665, Name = "São João de Meriti", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3666, Name = "São José de Ubá", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3667, Name = "São José do Vale do Rio Pret", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3668, Name = "São Pedro da Aldeia", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3669, Name = "São Sebastião do Alto", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3670, Name = "Sapucaia", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3671, Name = "Saquarema", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3672, Name = "Seropédica", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3673, Name = "Silva Jardim", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3674, Name = "Sumidouro", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3675, Name = "Tanguá", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3676, Name = "Teresópolis", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3677, Name = "Trajano de Morais", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3678, Name = "Três Rios", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3679, Name = "Valença", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3680, Name = "Varre-Sai", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3681, Name = "Vassouras", IdState = 19 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3682, Name = "Volta Redonda", IdState = 19 });
        }
        private static void Cities20(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3683, Name = "Acari", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3684, Name = "Açu", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3685, Name = "Afonso Bezerra", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3686, Name = "Água Nova", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3687, Name = "Alexandria", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3688, Name = "Almino Afonso", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3689, Name = "Alto do Rodrigues", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3690, Name = "Angicos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3691, Name = "Antônio Martins", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3692, Name = "Apodi", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3693, Name = "Areia Branca", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3694, Name = "Arês", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3695, Name = "Augusto Severo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3696, Name = "Baía Formosa", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3697, Name = "Baraúna", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3698, Name = "Barcelona", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3699, Name = "Bento Fernandes", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3700, Name = "Bodó", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3701, Name = "Bom Jesus", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3702, Name = "Brejinho", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3703, Name = "Caiçara do Norte", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3704, Name = "Caiçara do Rio do Vento", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3705, Name = "Caicó", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3706, Name = "Campo Redondo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3707, Name = "Canguaretama", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3708, Name = "Caraúbas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3709, Name = "Carnaúba dos Dantas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3710, Name = "Carnaubais", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3711, Name = "Ceará-Mirim", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3712, Name = "Cerro Corá", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3713, Name = "Coronel Ezequiel", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3714, Name = "Coronel João Pessoa", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3715, Name = "Cruzeta", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3716, Name = "Currais Novos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3717, Name = "Doutor Severiano", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3718, Name = "Encanto", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3719, Name = "Equador", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3720, Name = "Espírito Santo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3721, Name = "Extremoz", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3722, Name = "Felipe Guerra", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3723, Name = "Fernando Pedroza", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3724, Name = "Florânia", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3725, Name = "Francisco Dantas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3726, Name = "Frutuoso Gomes", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3727, Name = "Galinhos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3728, Name = "Goianinha", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3729, Name = "Governador Dix-Sept Rosado", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3730, Name = "Grossos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3731, Name = "Guamaré", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3732, Name = "Ielmo Marinho", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3733, Name = "Ipanguaçu", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3734, Name = "Ipueira", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3735, Name = "Itajá", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3736, Name = "Itaú", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3737, Name = "Jaçanã", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3738, Name = "Jandaíra", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3739, Name = "Janduís", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3740, Name = "Januário Cicco", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3741, Name = "Japi", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3742, Name = "Jardim de Angicos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3743, Name = "Jardim de Piranhas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3744, Name = "Jardim do Seridó", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3745, Name = "João Câmara", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3746, Name = "João Dias", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3747, Name = "José da Penha", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3748, Name = "Jucurutu", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3749, Name = "Jundiá", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3750, Name = "Lagoa d`Anta", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3751, Name = "Lagoa de Pedras", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3752, Name = "Lagoa de Velhos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3753, Name = "Lagoa Nova", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3754, Name = "Lagoa Salgada", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3755, Name = "Lajes", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3756, Name = "Lajes Pintadas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3757, Name = "Lucrécia", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3758, Name = "Luís Gomes", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3759, Name = "Macaíba", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3760, Name = "Macau", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3761, Name = "Major Sales", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3762, Name = "Marcelino Vieira", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3763, Name = "Martins", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3764, Name = "Maxaranguape", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3765, Name = "Messias Targino", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3766, Name = "Montanhas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3767, Name = "Monte Alegre", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3768, Name = "Monte das Gameleiras", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3769, Name = "Mossoró", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3770, Name = "Natal", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3771, Name = "Nísia Floresta", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3772, Name = "Nova Cruz", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3773, Name = "Olho-d`Água do Borges", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3774, Name = "Ouro Branco", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3775, Name = "Paraná", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3776, Name = "Paraú", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3777, Name = "Parazinho", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3778, Name = "Parelhas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3779, Name = "Parnamirim", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3780, Name = "Passa e Fica", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3781, Name = "Passagem", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3782, Name = "Patu", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3783, Name = "Pau dos Ferros", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3784, Name = "Pedra Grande", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3785, Name = "Pedra Preta", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3786, Name = "Pedro Avelino", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3787, Name = "Pedro Velho", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3788, Name = "Pendências", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3789, Name = "Pilões", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3790, Name = "Poço Branco", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3791, Name = "Portalegre", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3792, Name = "Porto do Mangue", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3793, Name = "Presidente Juscelino", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3794, Name = "Pureza", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3795, Name = "Rafael Fernandes", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3796, Name = "Rafael Godeiro", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3797, Name = "Riacho da Cruz", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3798, Name = "Riacho de Santana", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3799, Name = "Riachuelo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3800, Name = "Rio do Fogo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3801, Name = "Rodolfo Fernandes", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3802, Name = "Ruy Barbosa", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3803, Name = "Santa Cruz", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3804, Name = "Santa Maria", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3805, Name = "Santana do Matos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3806, Name = "Santana do Seridó", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3807, Name = "Santo Antônio", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3808, Name = "São Bento do Norte", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3809, Name = "São Bento do Trairí", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3810, Name = "São Fernando", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3811, Name = "São Francisco do Oeste", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3812, Name = "São Gonçalo do Amarante", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3813, Name = "São João do Sabugi", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3814, Name = "São José de Mipibu", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3815, Name = "São José do Campestre", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3816, Name = "São José do Seridó", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3817, Name = "São Miguel", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3818, Name = "São Miguel do Gostoso", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3819, Name = "São Paulo do Potengi", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3820, Name = "São Pedro", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3821, Name = "São Rafael", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3822, Name = "São Tomé", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3823, Name = "São Vicente", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3824, Name = "Senador Elói de Souza", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3825, Name = "Senador Georgino Avelino", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3826, Name = "Serra de São Bento", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3827, Name = "Serra do Mel", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3828, Name = "Serra Negra do Norte", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3829, Name = "Serrinha", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3830, Name = "Serrinha dos Pintos", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3831, Name = "Severiano Melo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3832, Name = "Sítio Novo", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3833, Name = "Taboleiro Grande", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3834, Name = "Taipu", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3835, Name = "Tangará", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3836, Name = "Tenente Ananias", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3837, Name = "Tenente Laurentino Cruz", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3838, Name = "Tibau", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3839, Name = "Tibau do Sul", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3840, Name = "Timbaúba dos Batistas", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3841, Name = "Touros", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3842, Name = "Triunfo Potiguar", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3843, Name = "Umarizal", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3844, Name = "Upanema", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3845, Name = "Várzea", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3846, Name = "Venha-Ver", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3847, Name = "Vera Cruz", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3848, Name = "Viçosa", IdState = 20 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3849, Name = "Vila Flor", IdState = 20 });
        }
        private static void Cities21(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4346, Name = "Alta Floresta d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4347, Name = "Alto Alegre dos Parecis", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4348, Name = "Alto Paraíso", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4349, Name = "Alvorada d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4350, Name = "Ariquemes", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4351, Name = "Buritis", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4352, Name = "Cabixi", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4353, Name = "Cacaulândia", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4354, Name = "Cacoal", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4355, Name = "Campo Novo de Rondônia", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4356, Name = "Candeias do Jamari", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4357, Name = "Castanheiras", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4358, Name = "Cerejeiras", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4359, Name = "Chupinguaia", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4360, Name = "Colorado do Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4361, Name = "Corumbiara", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4362, Name = "Costa Marques", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4363, Name = "Cujubim", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4364, Name = "Espigão d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4365, Name = "Governador Jorge Teixeira", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4366, Name = "Guajará-Mirim", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4367, Name = "Itapuã do Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4368, Name = "Jaru", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4369, Name = "Ji-Paraná", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4370, Name = "Machadinho d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4371, Name = "Ministro Andreazza", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4372, Name = "Mirante da Serra", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4373, Name = "Monte Negro", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4374, Name = "Nova Brasilândia d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4375, Name = "Nova Mamoré", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4376, Name = "Nova União", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4377, Name = "Novo Horizonte do Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4378, Name = "Ouro Preto do Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4379, Name = "Parecis", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4380, Name = "Pimenta Bueno", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4381, Name = "Pimenteiras do Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4382, Name = "Porto Velho", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4383, Name = "Presidente Médici", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4384, Name = "Primavera de Rondônia", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4385, Name = "Rio Crespo", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4386, Name = "Rolim de Moura", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4387, Name = "Santa Luzia d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4388, Name = "São Felipe d`Oeste", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4389, Name = "São Francisco do Guaporé", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4390, Name = "São Miguel do Guaporé", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4391, Name = "Seringueiras", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4392, Name = "Teixeirópolis", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4393, Name = "Theobroma", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4394, Name = "Urupá", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4395, Name = "Vale do Anari", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4396, Name = "Vale do Paraíso", IdState = 21 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4397, Name = "Vilhena", IdState = 21 });
        }
        private static void Cities22(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4398, Name = "Alto Alegre", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4399, Name = "Amajari", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4400, Name = "Boa Vista", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4401, Name = "Bonfim", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4402, Name = "Cantá", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4403, Name = "Caracaraí", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4404, Name = "Caroebe", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4405, Name = "Iracema", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4406, Name = "Mucajaí", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4407, Name = "Normandia", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4408, Name = "Pacaraima", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4409, Name = "Rorainópolis", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4410, Name = "São João da Baliza", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4411, Name = "São Luiz", IdState = 22 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4412, Name = "Uiramutã", IdState = 22 });
        }
        private static void Cities23(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3850, Name = "Aceguá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3851, Name = "Água Santa", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3852, Name = "Agudo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3853, Name = "Ajuricaba", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3854, Name = "Alecrim", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3855, Name = "Alegrete", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3856, Name = "Alegria", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3857, Name = "Almirante Tamandaré do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3858, Name = "Alpestre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3859, Name = "Alto Alegre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3860, Name = "Alto Feliz", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3861, Name = "Alvorada", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3862, Name = "Amaral Ferrador", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3863, Name = "Ametista do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3864, Name = "André da Rocha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3865, Name = "Anta Gorda", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3866, Name = "Antônio Prado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3867, Name = "Arambaré", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3868, Name = "Araricá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3869, Name = "Aratiba", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3870, Name = "Arroio do Meio", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3871, Name = "Arroio do Padre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3872, Name = "Arroio do Sal", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3873, Name = "Arroio do Tigre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3874, Name = "Arroio dos Ratos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3875, Name = "Arroio Grande", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3876, Name = "Arvorezinha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3877, Name = "Augusto Pestana", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3878, Name = "Áurea", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3879, Name = "Bagé", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3880, Name = "Balneário Pinhal", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3881, Name = "Barão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3882, Name = "Barão de Cotegipe", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3883, Name = "Barão do Triunfo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3884, Name = "Barra do Guarita", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3885, Name = "Barra do Quaraí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3886, Name = "Barra do Ribeiro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3887, Name = "Barra do Rio Azul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3888, Name = "Barra Funda", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3889, Name = "Barracão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3890, Name = "Barros Cassal", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3891, Name = "Benjamin Constant do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3892, Name = "Bento Gonçalves", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3893, Name = "Boa Vista das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3894, Name = "Boa Vista do Buricá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3895, Name = "Boa Vista do Cadeado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3896, Name = "Boa Vista do Incra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3897, Name = "Boa Vista do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3898, Name = "Bom Jesus", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3899, Name = "Bom Princípio", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3900, Name = "Bom Progresso", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3901, Name = "Bom Retiro do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3902, Name = "Boqueirão do Leão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3903, Name = "Bossoroca", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3904, Name = "Bozano", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3905, Name = "Braga", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3906, Name = "Brochier", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3907, Name = "Butiá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3908, Name = "Caçapava do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3909, Name = "Cacequi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3910, Name = "Cachoeira do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3911, Name = "Cachoeirinha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3912, Name = "Cacique Doble", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3913, Name = "Caibaté", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3914, Name = "Caiçara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3915, Name = "Camaquã", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3916, Name = "Camargo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3917, Name = "Cambará do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3918, Name = "Campestre da Serra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3919, Name = "Campina das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3920, Name = "Campinas do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3921, Name = "Campo Bom", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3922, Name = "Campo Novo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3923, Name = "Campos Borges", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3924, Name = "Candelária", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3925, Name = "Cândido Godói", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3926, Name = "Candiota", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3927, Name = "Canela", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3928, Name = "Canguçu", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3929, Name = "Canoas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3930, Name = "Canudos do Vale", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3931, Name = "Capão Bonito do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3932, Name = "Capão da Canoa", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3933, Name = "Capão do Cipó", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3934, Name = "Capão do Leão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3935, Name = "Capela de Santana", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3936, Name = "Capitão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3937, Name = "Capivari do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3938, Name = "Caraá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3939, Name = "Carazinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3940, Name = "Carlos Barbosa", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3941, Name = "Carlos Gomes", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3942, Name = "Casca", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3943, Name = "Caseiros", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3944, Name = "Catuípe", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3945, Name = "Caxias do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3946, Name = "Centenário", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3947, Name = "Cerrito", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3948, Name = "Cerro Branco", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3949, Name = "Cerro Grande", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3950, Name = "Cerro Grande do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3951, Name = "Cerro Largo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3952, Name = "Chapada", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3953, Name = "Charqueadas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3954, Name = "Charrua", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3955, Name = "Chiapeta", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3956, Name = "Chuí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3957, Name = "Chuvisca", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3958, Name = "Cidreira", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3959, Name = "Ciríaco", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3960, Name = "Colinas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3961, Name = "Colorado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3962, Name = "Condor", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3963, Name = "Constantina", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3964, Name = "Coqueiro Baixo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3965, Name = "Coqueiros do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3966, Name = "Coronel Barros", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3967, Name = "Coronel Bicaco", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3968, Name = "Coronel Pilar", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3969, Name = "Cotiporã", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3970, Name = "Coxilha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3971, Name = "Crissiumal", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3972, Name = "Cristal", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3973, Name = "Cristal do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3974, Name = "Cruz Alta", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3975, Name = "Cruzaltense", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3976, Name = "Cruzeiro do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3977, Name = "David Canabarro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3978, Name = "Derrubadas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3979, Name = "Dezesseis de Novembro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3980, Name = "Dilermando de Aguiar", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3981, Name = "Dois Irmãos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3982, Name = "Dois Irmãos das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3983, Name = "Dois Lajeados", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3984, Name = "Dom Feliciano", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3985, Name = "Dom Pedrito", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3986, Name = "Dom Pedro de Alcântara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3987, Name = "Dona Francisca", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3988, Name = "Doutor Maurício Cardoso", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3989, Name = "Doutor Ricardo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3990, Name = "Eldorado do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3991, Name = "Encantado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3992, Name = "Encruzilhada do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3993, Name = "Engenho Velho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3994, Name = "Entre Rios do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3995, Name = "Entre-Ijuís", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3996, Name = "Erebango", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3997, Name = "Erechim", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3998, Name = "Ernestina", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 3999, Name = "Erval Grande", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4000, Name = "Erval Seco", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4001, Name = "Esmeralda", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4002, Name = "Esperança do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4003, Name = "Espumoso", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4004, Name = "Estação", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4005, Name = "Estância Velha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4006, Name = "Esteio", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4007, Name = "Estrela", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4008, Name = "Estrela Velha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4009, Name = "Eugênio de Castro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4010, Name = "Fagundes Varela", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4011, Name = "Farroupilha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4012, Name = "Faxinal do Soturno", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4013, Name = "Faxinalzinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4014, Name = "Fazenda Vilanova", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4015, Name = "Feliz", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4016, Name = "Flores da Cunha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4017, Name = "Floriano Peixoto", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4018, Name = "Fontoura Xavier", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4019, Name = "Formigueiro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4020, Name = "Forquetinha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4021, Name = "Fortaleza dos Valos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4022, Name = "Frederico Westphalen", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4023, Name = "Garibaldi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4024, Name = "Garruchos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4025, Name = "Gaurama", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4026, Name = "General Câmara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4027, Name = "Gentil", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4028, Name = "Getúlio Vargas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4029, Name = "Giruá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4030, Name = "Glorinha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4031, Name = "Gramado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4032, Name = "Gramado dos Loureiros", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4033, Name = "Gramado Xavier", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4034, Name = "Gravataí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4035, Name = "Guabiju", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4036, Name = "Guaíba", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4037, Name = "Guaporé", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4038, Name = "Guarani das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4039, Name = "Harmonia", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4040, Name = "Herval", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4041, Name = "Herveiras", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4042, Name = "Horizontina", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4043, Name = "Hulha Negra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4044, Name = "Humaitá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4045, Name = "Ibarama", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4046, Name = "Ibiaçá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4047, Name = "Ibiraiaras", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4048, Name = "Ibirapuitã", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4049, Name = "Ibirubá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4050, Name = "Igrejinha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4051, Name = "Ijuí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4052, Name = "Ilópolis", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4053, Name = "Imbé", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4054, Name = "Imigrante", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4055, Name = "Independência", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4056, Name = "Inhacorá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4057, Name = "Ipê", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4058, Name = "Ipiranga do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4059, Name = "Iraí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4060, Name = "Itaara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4061, Name = "Itacurubi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4062, Name = "Itapuca", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4063, Name = "Itaqui", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4064, Name = "Itati", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4065, Name = "Itatiba do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4066, Name = "Ivorá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4067, Name = "Ivoti", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4068, Name = "Jaboticaba", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4069, Name = "Jacuizinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4070, Name = "Jacutinga", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4071, Name = "Jaguarão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4072, Name = "Jaguari", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4073, Name = "Jaquirana", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4074, Name = "Jari", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4075, Name = "Jóia", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4076, Name = "Júlio de Castilhos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4077, Name = "Lagoa Bonita do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4078, Name = "Lagoa dos Três Cantos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4079, Name = "Lagoa Vermelha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4080, Name = "Lagoão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4081, Name = "Lajeado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4082, Name = "Lajeado do Bugre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4083, Name = "Lavras do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4084, Name = "Liberato Salzano", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4085, Name = "Lindolfo Collor", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4086, Name = "Linha Nova", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4087, Name = "Maçambara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4088, Name = "Machadinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4089, Name = "Mampituba", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4090, Name = "Manoel Viana", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4091, Name = "Maquiné", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4092, Name = "Maratá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4093, Name = "Marau", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4094, Name = "Marcelino Ramos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4095, Name = "Mariana Pimentel", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4096, Name = "Mariano Moro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4097, Name = "Marques de Souza", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4098, Name = "Mata", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4099, Name = "Mato Castelhano", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4100, Name = "Mato Leitão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4101, Name = "Mato Queimado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4102, Name = "Maximiliano de Almeida", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4103, Name = "Minas do Leão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4104, Name = "Miraguaí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4105, Name = "Montauri", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4106, Name = "Monte Alegre dos Campos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4107, Name = "Monte Belo do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4108, Name = "Montenegro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4109, Name = "Mormaço", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4110, Name = "Morrinhos do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4111, Name = "Morro Redondo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4112, Name = "Morro Reuter", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4113, Name = "Mostardas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4114, Name = "Muçum", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4115, Name = "Muitos Capões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4116, Name = "Muliterno", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4117, Name = "Não-Me-Toque", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4118, Name = "Nicolau Vergueiro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4119, Name = "Nonoai", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4120, Name = "Nova Alvorada", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4121, Name = "Nova Araçá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4122, Name = "Nova Bassano", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4123, Name = "Nova Boa Vista", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4124, Name = "Nova Bréscia", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4125, Name = "Nova Candelária", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4126, Name = "Nova Esperança do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4127, Name = "Nova Hartz", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4128, Name = "Nova Pádua", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4129, Name = "Nova Palma", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4130, Name = "Nova Petrópolis", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4131, Name = "Nova Prata", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4132, Name = "Nova Ramada", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4133, Name = "Nova Roma do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4134, Name = "Nova Santa Rita", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4135, Name = "Novo Barreiro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4136, Name = "Novo Cabrais", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4137, Name = "Novo Hamburgo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4138, Name = "Novo Machado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4139, Name = "Novo Tiradentes", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4140, Name = "Novo Xingu", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4141, Name = "Osório", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4142, Name = "Paim Filho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4143, Name = "Palmares do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4144, Name = "Palmeira das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4145, Name = "Palmitinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4146, Name = "Panambi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4147, Name = "Pantano Grande", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4148, Name = "Paraí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4149, Name = "Paraíso do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4150, Name = "Pareci Novo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4151, Name = "Parobé", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4152, Name = "Passa Sete", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4153, Name = "Passo do Sobrado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4154, Name = "Passo Fundo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4155, Name = "Paulo Bento", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4156, Name = "Paverama", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4157, Name = "Pedras Altas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4158, Name = "Pedro Osório", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4159, Name = "Pejuçara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4160, Name = "Pelotas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4161, Name = "Picada Café", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4162, Name = "Pinhal", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4163, Name = "Pinhal da Serra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4164, Name = "Pinhal Grande", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4165, Name = "Pinheirinho do Vale", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4166, Name = "Pinheiro Machado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4167, Name = "Pirapó", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4168, Name = "Piratini", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4169, Name = "Planalto", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4170, Name = "Poço das Antas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4171, Name = "Pontão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4172, Name = "Ponte Preta", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4173, Name = "Portão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4174, Name = "Porto Alegre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4175, Name = "Porto Lucena", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4176, Name = "Porto Mauá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4177, Name = "Porto Vera Cruz", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4178, Name = "Porto Xavier", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4179, Name = "Pouso Novo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4180, Name = "Presidente Lucena", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4181, Name = "Progresso", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4182, Name = "Protásio Alves", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4183, Name = "Putinga", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4184, Name = "Quaraí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4185, Name = "Quatro Irmãos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4186, Name = "Quevedos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4187, Name = "Quinze de Novembro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4188, Name = "Redentora", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4189, Name = "Relvado", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4190, Name = "Restinga Seca", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4191, Name = "Rio dos Índios", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4192, Name = "Rio Grande", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4193, Name = "Rio Pardo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4194, Name = "Riozinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4195, Name = "Roca Sales", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4196, Name = "Rodeio Bonito", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4197, Name = "Rolador", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4198, Name = "Rolante", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4199, Name = "Ronda Alta", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4200, Name = "Rondinha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4201, Name = "Roque Gonzales", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4202, Name = "Rosário do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4203, Name = "Sagrada Família", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4204, Name = "Saldanha Marinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4205, Name = "Salto do Jacuí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4206, Name = "Salvador das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4207, Name = "Salvador do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4208, Name = "Sananduva", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4209, Name = "Santa Bárbara do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4210, Name = "Santa Cecília do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4211, Name = "Santa Clara do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4212, Name = "Santa Cruz do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4213, Name = "Santa Margarida do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4214, Name = "Santa Maria", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4215, Name = "Santa Maria do Herval", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4216, Name = "Santa Rosa", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4217, Name = "Santa Tereza", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4218, Name = "Santa Vitória do Palmar", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4219, Name = "Santana da Boa Vista", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4220, Name = "Santana do Livramento", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4221, Name = "Santiago", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4222, Name = "Santo Ângelo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4223, Name = "Santo Antônio da Patrulha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4224, Name = "Santo Antônio das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4225, Name = "Santo Antônio do Palma", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4226, Name = "Santo Antônio do Planalto", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4227, Name = "Santo Augusto", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4228, Name = "Santo Cristo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4229, Name = "Santo Expedito do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4230, Name = "São Borja", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4231, Name = "São Domingos do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4232, Name = "São Francisco de Assis", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4233, Name = "São Francisco de Paula", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4234, Name = "São Gabriel", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4235, Name = "São Jerônimo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4236, Name = "São João da Urtiga", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4237, Name = "São João do Polêsine", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4238, Name = "São Jorge", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4239, Name = "São José das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4240, Name = "São José do Herval", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4241, Name = "São José do Hortêncio", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4242, Name = "São José do Inhacorá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4243, Name = "São José do Norte", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4244, Name = "São José do Ouro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4245, Name = "São José do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4246, Name = "São José dos Ausentes", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4247, Name = "São Leopoldo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4248, Name = "São Lourenço do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4249, Name = "São Luiz Gonzaga", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4250, Name = "São Marcos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4251, Name = "São Martinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4252, Name = "São Martinho da Serra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4253, Name = "São Miguel das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4254, Name = "São Nicolau", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4255, Name = "São Paulo das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4256, Name = "São Pedro da Serra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4257, Name = "São Pedro das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4258, Name = "São Pedro do Butiá", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4259, Name = "São Pedro do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4260, Name = "São Sebastião do Caí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4261, Name = "São Sepé", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4262, Name = "São Valentim", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4263, Name = "São Valentim do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4264, Name = "São Valério do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4265, Name = "São Vendelino", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4266, Name = "São Vicente do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4267, Name = "Sapiranga", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4268, Name = "Sapucaia do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4269, Name = "Sarandi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4270, Name = "Seberi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4271, Name = "Sede Nova", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4272, Name = "Segredo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4273, Name = "Selbach", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4274, Name = "Senador Salgado Filho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4275, Name = "Sentinela do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4276, Name = "Serafina Corrêa", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4277, Name = "Sério", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4278, Name = "Sertão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4279, Name = "Sertão Santana", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4280, Name = "Sete de Setembro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4281, Name = "Severiano de Almeida", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4282, Name = "Silveira Martins", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4283, Name = "Sinimbu", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4284, Name = "Sobradinho", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4285, Name = "Soledade", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4286, Name = "Tabaí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4287, Name = "Tapejara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4288, Name = "Tapera", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4289, Name = "Tapes", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4290, Name = "Taquara", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4291, Name = "Taquari", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4292, Name = "Taquaruçu do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4293, Name = "Tavares", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4294, Name = "Tenente Portela", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4295, Name = "Terra de Areia", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4296, Name = "Teutônia", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4297, Name = "Tio Hugo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4298, Name = "Tiradentes do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4299, Name = "Toropi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4300, Name = "Torres", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4301, Name = "Tramandaí", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4302, Name = "Travesseiro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4303, Name = "Três Arroios", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4304, Name = "Três Cachoeiras", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4305, Name = "Três Coroas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4306, Name = "Três de Maio", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4307, Name = "Três Forquilhas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4308, Name = "Três Palmeiras", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4309, Name = "Três Passos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4310, Name = "Trindade do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4311, Name = "Triunfo", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4312, Name = "Tucunduva", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4313, Name = "Tunas", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4314, Name = "Tupanci do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4315, Name = "Tupanciretã", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4316, Name = "Tupandi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4317, Name = "Tuparendi", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4318, Name = "Turuçu", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4319, Name = "Ubiretama", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4320, Name = "União da Serra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4321, Name = "Unistalda", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4322, Name = "Uruguaiana", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4323, Name = "Vacaria", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4324, Name = "Vale do Sol", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4325, Name = "Vale Real", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4326, Name = "Vale Verde", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4327, Name = "Vanini", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4328, Name = "Venâncio Aires", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4329, Name = "Vera Cruz", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4330, Name = "Veranópolis", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4331, Name = "Vespasiano Correa", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4332, Name = "Viadutos", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4333, Name = "Viamão", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4334, Name = "Vicente Dutra", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4335, Name = "Victor Graeff", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4336, Name = "Vila Flores", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4337, Name = "Vila Lângaro", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4338, Name = "Vila Maria", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4339, Name = "Vila Nova do Sul", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4340, Name = "Vista Alegre", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4341, Name = "Vista Alegre do Prata", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4342, Name = "Vista Gaúcha", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4343, Name = "Vitória das Missões", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4344, Name = "Westfália", IdState = 23 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4345, Name = "Xangri-lá", IdState = 23 });
        }
        private static void Cities24(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4413, Name = "Abdon Batista", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4414, Name = "Abelardo Luz", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4415, Name = "Agrolândia", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4416, Name = "Agronômica", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4417, Name = "Água Doce", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4418, Name = "Águas de Chapecó", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4419, Name = "Águas Frias", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4420, Name = "Águas Mornas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4421, Name = "Alfredo Wagner", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4422, Name = "Alto Bela Vista", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4423, Name = "Anchieta", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4424, Name = "Angelina", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4425, Name = "Anita Garibaldi", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4426, Name = "Anitápolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4427, Name = "Antônio Carlos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4428, Name = "Apiúna", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4429, Name = "Arabutã", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4430, Name = "Araquari", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4431, Name = "Araranguá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4432, Name = "Armazém", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4433, Name = "Arroio Trinta", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4434, Name = "Arvoredo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4435, Name = "Ascurra", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4436, Name = "Atalanta", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4437, Name = "Aurora", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4438, Name = "Balneário Arroio do Silva", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4439, Name = "Balneário Barra do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4440, Name = "Balneário Camboriú", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4441, Name = "Balneário Gaivota", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4442, Name = "Bandeirante", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4443, Name = "Barra Bonita", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4444, Name = "Barra Velha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4445, Name = "Bela Vista do Toldo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4446, Name = "Belmonte", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4447, Name = "Benedito Novo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4448, Name = "Biguaçu", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4449, Name = "Blumenau", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4450, Name = "Bocaina do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4451, Name = "Bom Jardim da Serra", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4452, Name = "Bom Jesus", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4453, Name = "Bom Jesus do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4454, Name = "Bom Retiro", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4455, Name = "Bombinhas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4456, Name = "Botuverá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4457, Name = "Braço do Norte", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4458, Name = "Braço do Trombudo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4459, Name = "Brunópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4460, Name = "Brusque", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4461, Name = "Caçador", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4462, Name = "Caibi", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4463, Name = "Calmon", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4464, Name = "Camboriú", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4465, Name = "Campo Alegre", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4466, Name = "Campo Belo do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4467, Name = "Campo Erê", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4468, Name = "Campos Novos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4469, Name = "Canelinha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4470, Name = "Canoinhas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4471, Name = "Capão Alto", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4472, Name = "Capinzal", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4473, Name = "Capivari de Baixo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4474, Name = "Catanduvas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4475, Name = "Caxambu do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4476, Name = "Celso Ramos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4477, Name = "Cerro Negro", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4478, Name = "Chapadão do Lageado", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4479, Name = "Chapecó", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4480, Name = "Cocal do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4481, Name = "Concórdia", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4482, Name = "Cordilheira Alta", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4483, Name = "Coronel Freitas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4484, Name = "Coronel Martins", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4485, Name = "Correia Pinto", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4486, Name = "Corupá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4487, Name = "Criciúma", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4488, Name = "Cunha Porã", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4489, Name = "Cunhataí", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4490, Name = "Curitibanos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4491, Name = "Descanso", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4492, Name = "Dionísio Cerqueira", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4493, Name = "Dona Emma", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4494, Name = "Doutor Pedrinho", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4495, Name = "Entre Rios", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4496, Name = "Ermo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4497, Name = "Erval Velho", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4498, Name = "Faxinal dos Guedes", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4499, Name = "Flor do Sertão", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4500, Name = "Florianópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4501, Name = "Formosa do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4502, Name = "Forquilhinha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4503, Name = "Fraiburgo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4504, Name = "Frei Rogério", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4505, Name = "Galvão", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4506, Name = "Garopaba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4507, Name = "Garuva", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4508, Name = "Gaspar", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4509, Name = "Governador Celso Ramos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4510, Name = "Grão Pará", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4511, Name = "Gravatal", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4512, Name = "Guabiruba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4513, Name = "Guaraciaba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4514, Name = "Guaramirim", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4515, Name = "Guarujá do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4516, Name = "Guatambú", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4517, Name = "Herval d`Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4518, Name = "Ibiam", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4519, Name = "Ibicaré", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4520, Name = "Ibirama", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4521, Name = "Içara", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4522, Name = "Ilhota", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4523, Name = "Imaruí", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4524, Name = "Imbituba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4525, Name = "Imbuia", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4526, Name = "Indaial", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4527, Name = "Iomerê", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4528, Name = "Ipira", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4529, Name = "Iporã do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4530, Name = "Ipuaçu", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4531, Name = "Ipumirim", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4532, Name = "Iraceminha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4533, Name = "Irani", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4534, Name = "Irati", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4535, Name = "Irineópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4536, Name = "Itá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4537, Name = "Itaiópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4538, Name = "Itajaí", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4539, Name = "Itapema", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4540, Name = "Itapiranga", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4541, Name = "Itapoá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4542, Name = "Ituporanga", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4543, Name = "Jaborá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4544, Name = "Jacinto Machado", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4545, Name = "Jaguaruna", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4546, Name = "Jaraguá do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4547, Name = "Jardinópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4548, Name = "Joaçaba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4549, Name = "Joinville", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4550, Name = "José Boiteux", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4551, Name = "Jupiá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4552, Name = "Lacerdópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4553, Name = "Lages", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4554, Name = "Laguna", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4555, Name = "Lajeado Grande", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4556, Name = "Laurentino", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4557, Name = "Lauro Muller", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4558, Name = "Lebon Régis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4559, Name = "Leoberto Leal", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4560, Name = "Lindóia do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4561, Name = "Lontras", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4562, Name = "Luiz Alves", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4563, Name = "Luzerna", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4564, Name = "Macieira", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4565, Name = "Mafra", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4566, Name = "Major Gercino", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4567, Name = "Major Vieira", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4568, Name = "Maracajá", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4569, Name = "Maravilha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4570, Name = "Marema", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4571, Name = "Massaranduba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4572, Name = "Matos Costa", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4573, Name = "Meleiro", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4574, Name = "Mirim Doce", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4575, Name = "Modelo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4576, Name = "Mondaí", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4577, Name = "Monte Carlo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4578, Name = "Monte Castelo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4579, Name = "Morro da Fumaça", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4580, Name = "Morro Grande", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4581, Name = "Navegantes", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4582, Name = "Nova Erechim", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4583, Name = "Nova Itaberaba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4584, Name = "Nova Trento", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4585, Name = "Nova Veneza", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4586, Name = "Novo Horizonte", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4587, Name = "Orleans", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4588, Name = "Otacílio Costa", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4589, Name = "Ouro", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4590, Name = "Ouro Verde", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4591, Name = "Paial", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4592, Name = "Painel", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4593, Name = "Palhoça", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4594, Name = "Palma Sola", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4595, Name = "Palmeira", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4596, Name = "Palmitos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4597, Name = "Papanduva", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4598, Name = "Paraíso", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4599, Name = "Passo de Torres", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4600, Name = "Passos Maia", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4601, Name = "Paulo Lopes", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4602, Name = "Pedras Grandes", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4603, Name = "Penha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4604, Name = "Peritiba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4605, Name = "Petrolândia", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4606, Name = "Piçarras", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4607, Name = "Pinhalzinho", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4608, Name = "Pinheiro Preto", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4609, Name = "Piratuba", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4610, Name = "Planalto Alegre", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4611, Name = "Pomerode", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4612, Name = "Ponte Alta", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4613, Name = "Ponte Alta do Norte", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4614, Name = "Ponte Serrada", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4615, Name = "Porto Belo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4616, Name = "Porto União", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4617, Name = "Pouso Redondo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4618, Name = "Praia Grande", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4619, Name = "Presidente Castelo Branco", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4620, Name = "Presidente Getúlio", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4621, Name = "Presidente Nereu", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4622, Name = "Princesa", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4623, Name = "Quilombo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4624, Name = "Rancho Queimado", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4625, Name = "Rio das Antas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4626, Name = "Rio do Campo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4627, Name = "Rio do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4628, Name = "Rio do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4629, Name = "Rio dos Cedros", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4630, Name = "Rio Fortuna", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4631, Name = "Rio Negrinho", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4632, Name = "Rio Rufino", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4633, Name = "Riqueza", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4634, Name = "Rodeio", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4635, Name = "Romelândia", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4636, Name = "Salete", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4637, Name = "Saltinho", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4638, Name = "Salto Veloso", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4639, Name = "Sangão", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4640, Name = "Santa Cecília", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4641, Name = "Santa Helena", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4642, Name = "Santa Rosa de Lima", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4643, Name = "Santa Rosa do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4644, Name = "Santa Terezinha", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4645, Name = "Santa Terezinha do Progresso", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4646, Name = "Santiago do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4647, Name = "Santo Amaro da Imperatriz", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4648, Name = "São Bento do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4649, Name = "São Bernardino", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4650, Name = "São Bonifácio", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4651, Name = "São Carlos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4652, Name = "São Cristovão do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4653, Name = "São Domingos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4654, Name = "São Francisco do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4655, Name = "São João Batista", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4656, Name = "São João do Itaperiú", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4657, Name = "São João do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4658, Name = "São João do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4659, Name = "São Joaquim", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4660, Name = "São José", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4661, Name = "São José do Cedro", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4662, Name = "São José do Cerrito", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4663, Name = "São Lourenço do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4664, Name = "São Ludgero", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4665, Name = "São Martinho", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4666, Name = "São Miguel da Boa Vista", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4667, Name = "São Miguel do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4668, Name = "São Pedro de Alcântara", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4669, Name = "Saudades", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4670, Name = "Schroeder", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4671, Name = "Seara", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4672, Name = "Serra Alta", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4673, Name = "Siderópolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4674, Name = "Sombrio", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4675, Name = "Sul Brasil", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4676, Name = "Taió", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4677, Name = "Tangará", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4678, Name = "Tigrinhos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4679, Name = "Tijucas", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4680, Name = "Timbé do Sul", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4681, Name = "Timbó", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4682, Name = "Timbó Grande", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4683, Name = "Três Barras", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4684, Name = "Treviso", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4685, Name = "Treze de Maio", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4686, Name = "Treze Tílias", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4687, Name = "Trombudo Central", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4688, Name = "Tubarão", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4689, Name = "Tunápolis", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4690, Name = "Turvo", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4691, Name = "União do Oeste", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4692, Name = "Urubici", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4693, Name = "Urupema", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4694, Name = "Urussanga", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4695, Name = "Vargeão", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4696, Name = "Vargem", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4697, Name = "Vargem Bonita", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4698, Name = "Vidal Ramos", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4699, Name = "Videira", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4700, Name = "Vitor Meireles", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4701, Name = "Witmarsum", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4702, Name = "Xanxerê", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4703, Name = "Xavantina", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4704, Name = "Xaxim", IdState = 24 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4705, Name = "Zortéa", IdState = 24 });
        }
        private static void Cities25(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5351, Name = "Amparo de São Francisco", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5352, Name = "Aquidabã", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5353, Name = "Aracaju", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5354, Name = "Arauá", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5355, Name = "Areia Branca", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5356, Name = "Barra dos Coqueiros", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5357, Name = "Boquim", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5358, Name = "Brejo Grande", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5359, Name = "Campo do Brito", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5360, Name = "Canhoba", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5361, Name = "Canindé de São Francisco", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5362, Name = "Capela", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5363, Name = "Carira", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5364, Name = "Carmópolis", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5365, Name = "Cedro de São João", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5366, Name = "Cristinápolis", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5367, Name = "Cumbe", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5368, Name = "Divina Pastora", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5369, Name = "Estância", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5370, Name = "Feira Nova", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5371, Name = "Frei Paulo", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5372, Name = "Gararu", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5373, Name = "General Maynard", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5374, Name = "Gracho Cardoso", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5375, Name = "Ilha das Flores", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5376, Name = "Indiaroba", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5377, Name = "Itabaiana", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5378, Name = "Itabaianinha", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5379, Name = "Itabi", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5380, Name = "Itaporanga d`Ajuda", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5381, Name = "Japaratuba", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5382, Name = "Japoatã", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5383, Name = "Lagarto", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5384, Name = "Laranjeiras", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5385, Name = "Macambira", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5386, Name = "Malhada dos Bois", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5387, Name = "Malhador", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5388, Name = "Maruim", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5389, Name = "Moita Bonita", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5390, Name = "Monte Alegre de Sergipe", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5391, Name = "Muribeca", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5392, Name = "Neópolis", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5393, Name = "Nossa Senhora Aparecida", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5394, Name = "Nossa Senhora da Glória", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5395, Name = "Nossa Senhora das Dores", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5396, Name = "Nossa Senhora de Lourdes", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5397, Name = "Nossa Senhora do Socorro", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5398, Name = "Pacatuba", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5399, Name = "Pedra Mole", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5400, Name = "Pedrinhas", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5401, Name = "Pinhão", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5402, Name = "Pirambu", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5403, Name = "Poço Redondo", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5404, Name = "Poço Verde", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5405, Name = "Porto da Folha", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5406, Name = "Propriá", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5407, Name = "Riachão do Dantas", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5408, Name = "Riachuelo", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5409, Name = "Ribeirópolis", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5410, Name = "Rosário do Catete", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5411, Name = "Salgado", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5412, Name = "Santa Luzia do Itanhy", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5413, Name = "Santa Rosa de Lima", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5414, Name = "Santana do São Francisco", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5415, Name = "Santo Amaro das Brotas", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5416, Name = "São Cristóvão", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5417, Name = "São Domingos", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5418, Name = "São Francisco", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5419, Name = "São Miguel do Aleixo", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5420, Name = "Simão Dias", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5421, Name = "Siriri", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5422, Name = "Telha", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5423, Name = "Tobias Barreto", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5424, Name = "Tomar do Geru", IdState = 25 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5425, Name = "Umbaúba", IdState = 25 });
        }
        private static void Cities26(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4706, Name = "Adamantina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4707, Name = "Adolfo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4708, Name = "Aguaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4709, Name = "Águas da Prata", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4710, Name = "Águas de Lindóia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4711, Name = "Águas de Santa Bárbara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4712, Name = "Águas de São Pedro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4713, Name = "Agudos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4714, Name = "Alambari", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4715, Name = "Alfredo Marcondes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4716, Name = "Altair", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4717, Name = "Altinópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4718, Name = "Alto Alegre", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4719, Name = "Alumínio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4720, Name = "Álvares Florence", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4721, Name = "Álvares Machado", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4722, Name = "Álvaro de Carvalho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4723, Name = "Alvinlândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4724, Name = "Americana", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4725, Name = "Américo Brasiliense", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4726, Name = "Américo de Campos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4727, Name = "Amparo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4728, Name = "Analândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4729, Name = "Andradina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4730, Name = "Angatuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4731, Name = "Anhembi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4732, Name = "Anhumas", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4733, Name = "Aparecida", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4734, Name = "Aparecida d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4735, Name = "Apiaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4736, Name = "Araçariguama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4737, Name = "Araçatuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4738, Name = "Araçoiaba da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4739, Name = "Aramina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4740, Name = "Arandu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4741, Name = "Arapeí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4742, Name = "Araraquara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4743, Name = "Araras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4744, Name = "Arco-Íris", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4745, Name = "Arealva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4746, Name = "Areias", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4747, Name = "Areiópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4748, Name = "Ariranha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4749, Name = "Artur Nogueira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4750, Name = "Arujá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4751, Name = "Aspásia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4752, Name = "Assis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4753, Name = "Atibaia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4754, Name = "Auriflama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4755, Name = "Avaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4756, Name = "Avanhandava", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4757, Name = "Avaré", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4758, Name = "Bady Bassitt", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4759, Name = "Balbinos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4760, Name = "Bálsamo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4761, Name = "Bananal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4762, Name = "Barão de Antonina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4763, Name = "Barbosa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4764, Name = "Bariri", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4765, Name = "Barra Bonita", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4766, Name = "Barra do Chapéu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4767, Name = "Barra do Turvo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4768, Name = "Barretos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4769, Name = "Barrinha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4770, Name = "Barueri", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4771, Name = "Bastos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4772, Name = "Batatais", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4773, Name = "Bauru", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4774, Name = "Bebedouro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4775, Name = "Bento de Abreu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4776, Name = "Bernardino de Campos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4777, Name = "Bertioga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4778, Name = "Bilac", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4779, Name = "Birigui", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4780, Name = "Biritiba-Mirim", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4781, Name = "Boa Esperança do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4782, Name = "Bocaina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4783, Name = "Bofete", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4784, Name = "Boituva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4785, Name = "Bom Jesus dos Perdões", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4786, Name = "Bom Sucesso de Itararé", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4787, Name = "Borá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4788, Name = "Boracéia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4789, Name = "Borborema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4790, Name = "Borebi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4791, Name = "Botucatu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4792, Name = "Bragança Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4793, Name = "Braúna", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4794, Name = "Brejo Alegre", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4795, Name = "Brodowski", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4796, Name = "Brotas", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4797, Name = "Buri", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4798, Name = "Buritama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4799, Name = "Buritizal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4800, Name = "Cabrália Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4801, Name = "Cabreúva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4802, Name = "Caçapava", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4803, Name = "Cachoeira Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4804, Name = "Caconde", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4805, Name = "Cafelândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4806, Name = "Caiabu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4807, Name = "Caieiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4808, Name = "Caiuá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4809, Name = "Cajamar", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4810, Name = "Cajati", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4811, Name = "Cajobi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4812, Name = "Cajuru", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4813, Name = "Campina do Monte Alegre", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4814, Name = "Campinas", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4815, Name = "Campo Limpo Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4816, Name = "Campos do Jordão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4817, Name = "Campos Novos Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4818, Name = "Cananéia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4819, Name = "Canas", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4820, Name = "Cândido Mota", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4821, Name = "Cândido Rodrigues", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4822, Name = "Canitar", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4823, Name = "Capão Bonito", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4824, Name = "Capela do Alto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4825, Name = "Capivari", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4826, Name = "Caraguatatuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4827, Name = "Carapicuíba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4828, Name = "Cardoso", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4829, Name = "Casa Branca", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4830, Name = "Cássia dos Coqueiros", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4831, Name = "Castilho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4832, Name = "Catanduva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4833, Name = "Catiguá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4834, Name = "Cedral", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4835, Name = "Cerqueira César", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4836, Name = "Cerquilho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4837, Name = "Cesário Lange", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4838, Name = "Charqueada", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4839, Name = "Chavantes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4840, Name = "Clementina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4841, Name = "Colina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4842, Name = "Colômbia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4843, Name = "Conchal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4844, Name = "Conchas", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4845, Name = "Cordeirópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4846, Name = "Coroados", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4847, Name = "Coronel Macedo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4848, Name = "Corumbataí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4849, Name = "Cosmópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4850, Name = "Cosmorama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4851, Name = "Cotia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4852, Name = "Cravinhos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4853, Name = "Cristais Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4854, Name = "Cruzália", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4855, Name = "Cruzeiro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4856, Name = "Cubatão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4857, Name = "Cunha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4858, Name = "Descalvado", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4859, Name = "Diadema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4860, Name = "Dirce Reis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4861, Name = "Divinolândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4862, Name = "Dobrada", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4863, Name = "Dois Córregos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4864, Name = "Dolcinópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4865, Name = "Dourado", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4866, Name = "Dracena", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4867, Name = "Duartina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4868, Name = "Dumont", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4869, Name = "Echaporã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4870, Name = "Eldorado", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4871, Name = "Elias Fausto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4872, Name = "Elisiário", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4873, Name = "Embaúba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4874, Name = "Embu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4875, Name = "Embu-Guaçu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4876, Name = "Emilianópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4877, Name = "Engenheiro Coelho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4878, Name = "Espírito Santo do Pinhal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4879, Name = "Espírito Santo do Turvo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4880, Name = "Estiva Gerbi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4881, Name = "Estrela d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4882, Name = "Estrela do Norte", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4883, Name = "Euclides da Cunha Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4884, Name = "Fartura", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4885, Name = "Fernando Prestes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4886, Name = "Fernandópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4887, Name = "Fernão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4888, Name = "Ferraz de Vasconcelos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4889, Name = "Flora Rica", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4890, Name = "Floreal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4891, Name = "Flórida Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4892, Name = "Florínia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4893, Name = "Franca", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4894, Name = "Francisco Morato", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4895, Name = "Franco da Rocha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4896, Name = "Gabriel Monteiro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4897, Name = "Gália", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4898, Name = "Garça", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4899, Name = "Gastão Vidigal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4900, Name = "Gavião Peixoto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4901, Name = "General Salgado", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4902, Name = "Getulina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4903, Name = "Glicério", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4904, Name = "Guaiçara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4905, Name = "Guaimbê", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4906, Name = "Guaíra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4907, Name = "Guapiaçu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4908, Name = "Guapiara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4909, Name = "Guará", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4910, Name = "Guaraçaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4911, Name = "Guaraci", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4912, Name = "Guarani d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4913, Name = "Guarantã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4914, Name = "Guararapes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4915, Name = "Guararema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4916, Name = "Guaratinguetá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4917, Name = "Guareí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4918, Name = "Guariba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4919, Name = "Guarujá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4920, Name = "Guarulhos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4921, Name = "Guatapará", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4922, Name = "Guzolândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4923, Name = "Herculândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4924, Name = "Holambra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4925, Name = "Hortolândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4926, Name = "Iacanga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4927, Name = "Iacri", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4928, Name = "Iaras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4929, Name = "Ibaté", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4930, Name = "Ibirá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4931, Name = "Ibirarema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4932, Name = "Ibitinga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4933, Name = "Ibiúna", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4934, Name = "Icém", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4935, Name = "Iepê", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4936, Name = "Igaraçu do Tietê", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4937, Name = "Igarapava", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4938, Name = "Igaratá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4939, Name = "Iguape", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4940, Name = "Ilha Comprida", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4941, Name = "Ilha Solteira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4942, Name = "Ilhabela", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4943, Name = "Indaiatuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4944, Name = "Indiana", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4945, Name = "Indiaporã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4946, Name = "Inúbia Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4947, Name = "Ipaussu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4948, Name = "Iperó", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4949, Name = "Ipeúna", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4950, Name = "Ipiguá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4951, Name = "Iporanga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4952, Name = "Ipuã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4953, Name = "Iracemápolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4954, Name = "Irapuã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4955, Name = "Irapuru", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4956, Name = "Itaberá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4957, Name = "Itaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4958, Name = "Itajobi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4959, Name = "Itaju", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4960, Name = "Itanhaém", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4961, Name = "Itaóca", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4962, Name = "Itapecerica da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4963, Name = "Itapetininga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4964, Name = "Itapeva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4965, Name = "Itapevi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4966, Name = "Itapira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4967, Name = "Itapirapuã Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4968, Name = "Itápolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4969, Name = "Itaporanga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4970, Name = "Itapuí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4971, Name = "Itapura", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4972, Name = "Itaquaquecetuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4973, Name = "Itararé", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4974, Name = "Itariri", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4975, Name = "Itatiba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4976, Name = "Itatinga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4977, Name = "Itirapina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4978, Name = "Itirapuã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4979, Name = "Itobi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4980, Name = "Itu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4981, Name = "Itupeva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4982, Name = "Ituverava", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4983, Name = "Jaborandi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4984, Name = "Jaboticabal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4985, Name = "Jacareí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4986, Name = "Jaci", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4987, Name = "Jacupiranga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4988, Name = "Jaguariúna", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4989, Name = "Jales", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4990, Name = "Jambeiro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4991, Name = "Jandira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4992, Name = "Jardinópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4993, Name = "Jarinu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4994, Name = "Jaú", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4995, Name = "Jeriquara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4996, Name = "Joanópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4997, Name = "João Ramalho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4998, Name = "José Bonifácio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 4999, Name = "Júlio Mesquita", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5000, Name = "Jumirim", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5001, Name = "Jundiaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5002, Name = "Junqueirópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5003, Name = "Juquiá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5004, Name = "Juquitiba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5005, Name = "Lagoinha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5006, Name = "Laranjal Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5007, Name = "Lavínia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5008, Name = "Lavrinhas", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5009, Name = "Leme", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5010, Name = "Lençóis Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5011, Name = "Limeira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5012, Name = "Lindóia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5013, Name = "Lins", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5014, Name = "Lorena", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5015, Name = "Lourdes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5016, Name = "Louveira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5017, Name = "Lucélia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5018, Name = "Lucianópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5019, Name = "Luís Antônio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5020, Name = "Luiziânia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5021, Name = "Lupércio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5022, Name = "Lutécia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5023, Name = "Macatuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5024, Name = "Macaubal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5025, Name = "Macedônia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5026, Name = "Magda", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5027, Name = "Mairinque", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5028, Name = "Mairiporã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5029, Name = "Manduri", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5030, Name = "Marabá Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5031, Name = "Maracaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5032, Name = "Marapoama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5033, Name = "Mariápolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5034, Name = "Marília", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5035, Name = "Marinópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5036, Name = "Martinópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5037, Name = "Matão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5038, Name = "Mauá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5039, Name = "Mendonça", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5040, Name = "Meridiano", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5041, Name = "Mesópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5042, Name = "Miguelópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5043, Name = "Mineiros do Tietê", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5044, Name = "Mira Estrela", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5045, Name = "Miracatu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5046, Name = "Mirandópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5047, Name = "Mirante do Paranapanema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5048, Name = "Mirassol", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5049, Name = "Mirassolândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5050, Name = "Mococa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5051, Name = "Mogi das Cruzes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5052, Name = "Mogi Guaçu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5053, Name = "Moji Mirim", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5054, Name = "Mombuca", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5055, Name = "Monções", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5056, Name = "Mongaguá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5057, Name = "Monte Alegre do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5058, Name = "Monte Alto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5059, Name = "Monte Aprazível", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5060, Name = "Monte Azul Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5061, Name = "Monte Castelo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5062, Name = "Monte Mor", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5063, Name = "Monteiro Lobato", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5064, Name = "Morro Agudo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5065, Name = "Morungaba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5066, Name = "Motuca", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5067, Name = "Murutinga do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5068, Name = "Nantes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5069, Name = "Narandiba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5070, Name = "Natividade da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5071, Name = "Nazaré Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5072, Name = "Neves Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5073, Name = "Nhandeara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5074, Name = "Nipoã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5075, Name = "Nova Aliança", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5076, Name = "Nova Campina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5077, Name = "Nova Canaã Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5078, Name = "Nova Castilho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5079, Name = "Nova Europa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5080, Name = "Nova Granada", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5081, Name = "Nova Guataporanga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5082, Name = "Nova Independência", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5083, Name = "Nova Luzitânia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5084, Name = "Nova Odessa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5085, Name = "Novais", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5086, Name = "Novo Horizonte", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5087, Name = "Nuporanga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5088, Name = "Ocauçu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5089, Name = "Óleo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5090, Name = "Olímpia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5091, Name = "Onda Verde", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5092, Name = "Oriente", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5093, Name = "Orindiúva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5094, Name = "Orlândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5095, Name = "Osasco", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5096, Name = "Oscar Bressane", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5097, Name = "Osvaldo Cruz", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5098, Name = "Ourinhos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5099, Name = "Ouro Verde", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5100, Name = "Ouroeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5101, Name = "Pacaembu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5102, Name = "Palestina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5103, Name = "Palmares Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5104, Name = "Palmeira d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5105, Name = "Palmital", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5106, Name = "Panorama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5107, Name = "Paraguaçu Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5108, Name = "Paraibuna", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5109, Name = "Paraíso", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5110, Name = "Paranapanema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5111, Name = "Paranapuã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5112, Name = "Parapuã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5113, Name = "Pardinho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5114, Name = "Pariquera-Açu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5115, Name = "Parisi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5116, Name = "Patrocínio Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5117, Name = "Paulicéia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5118, Name = "Paulínia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5119, Name = "Paulistânia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5120, Name = "Paulo de Faria", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5121, Name = "Pederneiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5122, Name = "Pedra Bela", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5123, Name = "Pedranópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5124, Name = "Pedregulho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5125, Name = "Pedreira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5126, Name = "Pedrinhas Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5127, Name = "Pedro de Toledo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5128, Name = "Penápolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5129, Name = "Pereira Barreto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5130, Name = "Pereiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5131, Name = "Peruíbe", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5132, Name = "Piacatu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5133, Name = "Piedade", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5134, Name = "Pilar do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5135, Name = "Pindamonhangaba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5136, Name = "Pindorama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5137, Name = "Pinhalzinho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5138, Name = "Piquerobi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5139, Name = "Piquete", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5140, Name = "Piracaia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5141, Name = "Piracicaba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5142, Name = "Piraju", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5143, Name = "Pirajuí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5144, Name = "Pirangi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5145, Name = "Pirapora do Bom Jesus", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5146, Name = "Pirapozinho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5147, Name = "Pirassununga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5148, Name = "Piratininga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5149, Name = "Pitangueiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5150, Name = "Planalto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5151, Name = "Platina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5152, Name = "Poá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5153, Name = "Poloni", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5154, Name = "Pompéia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5155, Name = "Pongaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5156, Name = "Pontal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5157, Name = "Pontalinda", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5158, Name = "Pontes Gestal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5159, Name = "Populina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5160, Name = "Porangaba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5161, Name = "Porto Feliz", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5162, Name = "Porto Ferreira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5163, Name = "Potim", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5164, Name = "Potirendaba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5165, Name = "Pracinha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5166, Name = "Pradópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5167, Name = "Praia Grande", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5168, Name = "Pratânia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5169, Name = "Presidente Alves", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5170, Name = "Presidente Bernardes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5171, Name = "Presidente Epitácio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5172, Name = "Presidente Prudente", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5173, Name = "Presidente Venceslau", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5174, Name = "Promissão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5175, Name = "Quadra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5176, Name = "Quatá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5177, Name = "Queiroz", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5178, Name = "Queluz", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5179, Name = "Quintana", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5180, Name = "Rafard", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5181, Name = "Rancharia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5182, Name = "Redenção da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5183, Name = "Regente Feijó", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5184, Name = "Reginópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5185, Name = "Registro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5186, Name = "Restinga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5187, Name = "Ribeira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5188, Name = "Ribeirão Bonito", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5189, Name = "Ribeirão Branco", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5190, Name = "Ribeirão Corrente", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5191, Name = "Ribeirão do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5192, Name = "Ribeirão dos Índios", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5193, Name = "Ribeirão Grande", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5194, Name = "Ribeirão Pires", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5195, Name = "Ribeirão Preto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5196, Name = "Rifaina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5197, Name = "Rincão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5198, Name = "Rinópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5199, Name = "Rio Claro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5200, Name = "Rio das Pedras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5201, Name = "Rio Grande da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5202, Name = "Riolândia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5203, Name = "Riversul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5204, Name = "Rosana", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5205, Name = "Roseira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5206, Name = "Rubiácea", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5207, Name = "Rubinéia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5208, Name = "Sabino", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5209, Name = "Sagres", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5210, Name = "Sales", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5211, Name = "Sales Oliveira", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5212, Name = "Salesópolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5213, Name = "Salmourão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5214, Name = "Saltinho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5215, Name = "Salto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5216, Name = "Salto de Pirapora", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5217, Name = "Salto Grande", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5218, Name = "Sandovalina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5219, Name = "Santa Adélia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5220, Name = "Santa Albertina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5221, Name = "Santa Bárbara d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5222, Name = "Santa Branca", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5223, Name = "Santa Clara d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5224, Name = "Santa Cruz da Conceição", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5225, Name = "Santa Cruz da Esperança", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5226, Name = "Santa Cruz das Palmeiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5227, Name = "Santa Cruz do Rio Pardo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5228, Name = "Santa Ernestina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5229, Name = "Santa Fé do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5230, Name = "Santa Gertrudes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5231, Name = "Santa Isabel", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5232, Name = "Santa Lúcia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5233, Name = "Santa Maria da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5234, Name = "Santa Mercedes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5235, Name = "Santa Rita d`Oeste", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5236, Name = "Santa Rita do Passa Quatro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5237, Name = "Santa Rosa de Viterbo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5238, Name = "Santa Salete", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5239, Name = "Santana da Ponte Pensa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5240, Name = "Santana de Parnaíba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5241, Name = "Santo Anastácio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5242, Name = "Santo André", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5243, Name = "Santo Antônio da Alegria", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5244, Name = "Santo Antônio de Posse", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5245, Name = "Santo Antônio do Aracanguá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5246, Name = "Santo Antônio do Jardim", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5247, Name = "Santo Antônio do Pinhal", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5248, Name = "Santo Expedito", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5249, Name = "Santópolis do Aguapeí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5250, Name = "Santos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5251, Name = "São Bento do Sapucaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5252, Name = "São Bernardo do Campo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5253, Name = "São Caetano do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5254, Name = "São Carlos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5255, Name = "São Francisco", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5256, Name = "São João da Boa Vista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5257, Name = "São João das Duas Pontes", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5258, Name = "São João de Iracema", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5259, Name = "São João do Pau d`Alho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5260, Name = "São Joaquim da Barra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5261, Name = "São José da Bela Vista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5262, Name = "São José do Barreiro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5263, Name = "São José do Rio Pardo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5264, Name = "São José do Rio Preto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5265, Name = "São José dos Campos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5266, Name = "São Lourenço da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5267, Name = "São Luís do Paraitinga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5268, Name = "São Manuel", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5269, Name = "São Miguel Arcanjo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5270, Name = "São Paulo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5271, Name = "São Pedro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5272, Name = "São Pedro do Turvo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5273, Name = "São Roque", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5274, Name = "São Sebastião", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5275, Name = "São Sebastião da Grama", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5276, Name = "São Simão", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5277, Name = "São Vicente", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5278, Name = "Sarapuí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5279, Name = "Sarutaiá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5280, Name = "Sebastianópolis do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5281, Name = "Serra Azul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5282, Name = "Serra Negra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5283, Name = "Serrana", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5284, Name = "Sertãozinho", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5285, Name = "Sete Barras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5286, Name = "Severínia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5287, Name = "Silveiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5288, Name = "Socorro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5289, Name = "Sorocaba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5290, Name = "Sud Mennucci", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5291, Name = "Sumaré", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5292, Name = "Suzanápolis", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5293, Name = "Suzano", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5294, Name = "Tabapuã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5295, Name = "Tabatinga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5296, Name = "Taboão da Serra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5297, Name = "Taciba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5298, Name = "Taguaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5299, Name = "Taiaçu", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5300, Name = "Taiúva", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5301, Name = "Tambaú", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5302, Name = "Tanabi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5303, Name = "Tapiraí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5304, Name = "Tapiratiba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5305, Name = "Taquaral", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5306, Name = "Taquaritinga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5307, Name = "Taquarituba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5308, Name = "Taquarivaí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5309, Name = "Tarabai", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5310, Name = "Tarumã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5311, Name = "Tatuí", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5312, Name = "Taubaté", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5313, Name = "Tejupá", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5314, Name = "Teodoro Sampaio", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5315, Name = "Terra Roxa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5316, Name = "Tietê", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5317, Name = "Timburi", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5318, Name = "Torre de Pedra", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5319, Name = "Torrinha", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5320, Name = "Trabiju", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5321, Name = "Tremembé", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5322, Name = "Três Fronteiras", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5323, Name = "Tuiuti", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5324, Name = "Tupã", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5325, Name = "Tupi Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5326, Name = "Turiúba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5327, Name = "Turmalina", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5328, Name = "Ubarana", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5329, Name = "Ubatuba", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5330, Name = "Ubirajara", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5331, Name = "Uchoa", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5332, Name = "União Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5333, Name = "Urânia", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5334, Name = "Uru", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5335, Name = "Urupês", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5336, Name = "Valentim Gentil", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5337, Name = "Valinhos", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5338, Name = "Valparaíso", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5339, Name = "Vargem", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5340, Name = "Vargem Grande do Sul", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5341, Name = "Vargem Grande Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5342, Name = "Várzea Paulista", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5343, Name = "Vera Cruz", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5344, Name = "Vinhedo", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5345, Name = "Viradouro", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5346, Name = "Vista Alegre do Alto", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5347, Name = "Vitória Brasil", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5348, Name = "Votorantim", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5349, Name = "Votuporanga", IdState = 26 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5350, Name = "Zacarias", IdState = 26 });
        }
        private static void Cities27(AppContext context)
        {
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5426, Name = "Abreulândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5427, Name = "Aguiarnópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5428, Name = "Aliança do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5429, Name = "Almas", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5430, Name = "Alvorada", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5431, Name = "Ananás", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5432, Name = "Angico", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5433, Name = "Aparecida do Rio Negro", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5434, Name = "Aragominas", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5435, Name = "Araguacema", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5436, Name = "Araguaçu", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5437, Name = "Araguaína", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5438, Name = "Araguanã", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5439, Name = "Araguatins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5440, Name = "Arapoema", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5441, Name = "Arraias", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5442, Name = "Augustinópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5443, Name = "Aurora do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5444, Name = "Axixá do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5445, Name = "Babaçulândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5446, Name = "Bandeirantes do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5447, Name = "Barra do Ouro", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5448, Name = "Barrolândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5449, Name = "Bernardo Sayão", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5450, Name = "Bom Jesus do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5451, Name = "Brasilândia do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5452, Name = "Brejinho de Nazaré", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5453, Name = "Buriti do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5454, Name = "Cachoeirinha", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5455, Name = "Campos Lindos", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5456, Name = "Cariri do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5457, Name = "Carmolândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5458, Name = "Carrasco Bonito", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5459, Name = "Caseara", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5460, Name = "Centenário", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5461, Name = "Chapada da Natividade", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5462, Name = "Chapada de Areia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5463, Name = "Colinas do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5464, Name = "Colméia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5465, Name = "Combinado", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5466, Name = "Conceição do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5467, Name = "Couto de Magalhães", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5468, Name = "Cristalândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5469, Name = "Crixás do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5470, Name = "Darcinópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5471, Name = "Dianópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5472, Name = "Divinópolis do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5473, Name = "Dois Irmãos do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5474, Name = "Dueré", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5475, Name = "Esperantina", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5476, Name = "Fátima", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5477, Name = "Figueirópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5478, Name = "Filadélfia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5479, Name = "Formoso do Araguaia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5480, Name = "Fortaleza do Tabocão", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5481, Name = "Goianorte", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5482, Name = "Goiatins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5483, Name = "Guaraí", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5484, Name = "Gurupi", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5485, Name = "Ipueiras", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5486, Name = "Itacajá", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5487, Name = "Itaguatins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5488, Name = "Itapiratins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5489, Name = "Itaporã do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5490, Name = "Jaú do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5491, Name = "Juarina", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5492, Name = "Lagoa da Confusão", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5493, Name = "Lagoa do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5494, Name = "Lajeado", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5495, Name = "Lavandeira", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5496, Name = "Lizarda", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5497, Name = "Luzinópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5498, Name = "Marianópolis do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5499, Name = "Mateiros", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5500, Name = "Maurilândia do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5501, Name = "Miracema do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5502, Name = "Miranorte", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5503, Name = "Monte do Carmo", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5504, Name = "Monte Santo do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5505, Name = "Muricilândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5506, Name = "Natividade", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5507, Name = "Nazaré", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5508, Name = "Nova Olinda", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5509, Name = "Nova Rosalândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5510, Name = "Novo Acordo", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5511, Name = "Novo Alegre", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5512, Name = "Novo Jardim", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5513, Name = "Oliveira de Fátima", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5514, Name = "Palmas", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5515, Name = "Palmeirante", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5516, Name = "Palmeiras do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5517, Name = "Palmeirópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5518, Name = "Paraíso do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5519, Name = "Paranã", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5520, Name = "Pau d`Arco", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5521, Name = "Pedro Afonso", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5522, Name = "Peixe", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5523, Name = "Pequizeiro", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5524, Name = "Pindorama do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5525, Name = "Piraquê", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5526, Name = "Pium", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5527, Name = "Ponte Alta do Bom Jesus", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5528, Name = "Ponte Alta do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5529, Name = "Porto Alegre do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5530, Name = "Porto Nacional", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5531, Name = "Praia Norte", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5532, Name = "Presidente Kennedy", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5533, Name = "Pugmil", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5534, Name = "Recursolândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5535, Name = "Riachinho", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5536, Name = "Rio da Conceição", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5537, Name = "Rio dos Bois", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5538, Name = "Rio Sono", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5539, Name = "Sampaio", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5540, Name = "Sandolândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5541, Name = "Santa Fé do Araguaia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5542, Name = "Santa Maria do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5543, Name = "Santa Rita do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5544, Name = "Santa Rosa do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5545, Name = "Santa Tereza do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5546, Name = "Santa Terezinha do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5547, Name = "São Bento do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5548, Name = "São Félix do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5549, Name = "São Miguel do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5550, Name = "São Salvador do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5551, Name = "São Sebastião do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5552, Name = "São Valério da Natividade", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5553, Name = "Silvanópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5554, Name = "Sítio Novo do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5555, Name = "Sucupira", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5556, Name = "Taguatinga", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5557, Name = "Taipas do Tocantins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5558, Name = "Talismã", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5559, Name = "Tocantínia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5560, Name = "Tocantinópolis", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5561, Name = "Tupirama", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5562, Name = "Tupiratins", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5563, Name = "Wanderlândia", IdState = 27 });
            context.Cities.AddOrUpdate(c => c.Id, new City { Id = 5564, Name = "Xambioá", IdState = 27 });
        }
        private void SeedStock(AppContext context)
        {
            TocaProPaiPretoStock(context);
            TocaProPaiBrancoStock(context);
            EuPensoVoceCorreBrancoStock(context);
            EuPensoVoceCorreVermelhoStock(context);
            JogouOndeParceiroPreto(context);
            JogouOndeParceiroAzulMarinho(context);
            DezeFaixaBrancoStock(context);
            DezeFaixaCinzaClaro(context);

        }
        private static void DezeFaixaCinzaClaro(AppContext context)
        {

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 22, IdProduct = 8, IdColor = 5, IdSize = 1, Quantity = 2 });

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 23, IdProduct = 8, IdColor = 5, IdSize = 2, Quantity = 5 });

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 24, IdProduct = 8, IdColor = 5, IdSize = 3, Quantity = 5 });
        }
        private static void DezeFaixaBrancoStock(AppContext context)
        {
            // 10&Faixa  - P -  Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 19, IdProduct = 7, IdColor = 2, IdSize = 1, Quantity = 3 });

            // 10&Faixa  - M - Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 20, IdProduct = 7, IdColor = 2, IdSize = 2, Quantity = 13 });

            // 10&Faixa - G - Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 21, IdProduct = 7, IdColor = 2, IdSize = 3, Quantity = 4 });
        }
        private static void JogouOndeParceiroAzulMarinho(AppContext context)
        {
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 16, IdProduct = 6, IdColor = 3, IdSize = 1, Quantity = 0 });

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 17, IdProduct = 6, IdColor = 3, IdSize = 2, Quantity = 3 });

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 18, IdProduct = 6, IdColor = 3, IdSize = 3, Quantity = 5 });
        }
        private static void JogouOndeParceiroPreto(AppContext context)
        {
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 13, IdProduct = 5, IdColor = 1, IdSize = 1, Quantity = 2 });

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 14, IdProduct = 5, IdColor = 1, IdSize = 2, Quantity = 3 });

            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 15, IdProduct = 5, IdColor = 1, IdSize = 3, Quantity = 2 });
        }
        private static void EuPensoVoceCorreVermelhoStock(AppContext context)
        {
            // Eu penso, voce corre - P -  Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 10, IdProduct = 4, IdColor = 4, IdSize = 1, Quantity = 1 });

            // Eu penso, voce corre  - M - Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 11, IdProduct = 4, IdColor = 4, IdSize = 2, Quantity = 3 });

            // Eu penso, voce corre - G - Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 12, IdProduct = 4, IdColor = 4, IdSize = 3, Quantity = 3 });
        }
        private static void EuPensoVoceCorreBrancoStock(AppContext context)
        {
            // Eu penso, voce corre - P -  Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 7, IdProduct = 3, IdColor = 2, IdSize = 1, Quantity = 4 });

            // Eu penso, voce corre  - M - Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 8, IdProduct = 3, IdColor = 2, IdSize = 2, Quantity = 8 });

            // Eu penso, voce corre - G - Branca  
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 9, IdProduct = 3, IdColor = 2, IdSize = 3, Quantity = 10 });
        }
        private static void TocaProPaiBrancoStock(AppContext context)
        {
            // Toca pro pai - P -  Branca
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 4, IdProduct = 2, IdColor = 2, IdSize = 1, Quantity = 3 });

            // Toca pro pai - M - Branca 
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 5, IdProduct = 2, IdColor = 2, IdSize = 2, Quantity = 7 });

            // Toca pro pai - G - Branca 
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 6, IdProduct = 2, IdColor = 2, IdSize = 3, Quantity = 9 });
        }
        private static void TocaProPaiPretoStock(AppContext context)
        {
            // Toca pro pai - P - Preta 
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 1, IdProduct = 1, IdColor = 1, IdSize = 1, Quantity = 1 });

            // Toca pro pai - M - Preta 
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 2, IdProduct = 1, IdColor = 1, IdSize = 2, Quantity = 0 });

            // Toca pro pai - G - Preta 
            context.Stocks.AddOrUpdate(
             c => c.Id,
             new Stock { Id = 3, IdProduct = 1, IdColor = 1, IdSize = 3, Quantity = 3 });
        }
        private static void SeedCategories(AppContext context)
        {
            context.Categories.AddOrUpdate(
              c => c.Id,
              new ProductCategory { Id = 1, Name = "Camisetas", Active = true });

            context.Categories.AddOrUpdate(
           c => c.Id,
           new ProductCategory { Id = 2, Name = "Toca pro Pai", Active = true, IdRootCategory = 1 });

            context.Categories.AddOrUpdate(
             c => c.Id,
             new ProductCategory { Id = 3, Name = "Eu penso, você corre", Active = true, IdRootCategory = 1 });

            context.Categories.AddOrUpdate(
                  c => c.Id,
                  new ProductCategory { Id = 4, Name = "Eu estou aqui", Active = false, IdRootCategory = 1 });

            context.Categories.AddOrUpdate(
           c => c.Id,
           new ProductCategory { Id = 5, Name = "Jogou onde parceiro", Active = true, IdRootCategory = 1 });


            context.Categories.AddOrUpdate(
           c => c.Id,
           new ProductCategory { Id = 6, Name = "Meto a mala", Active = false, IdRootCategory = 1 });

            context.Categories.AddOrUpdate(
           c => c.Id,
           new ProductCategory { Id = 7, Name = "10 e Faixa", Active = true, IdRootCategory = 1 });

            context.Categories.AddOrUpdate(
        c => c.Id,
        new ProductCategory { Id = 8, Name = "Estilo F.C.", Active = false, IdRootCategory = 1 });

        }
        private static void SeedProducts(AppContext context)
        {

            SeedCategory2(context);
            SeedCategory3(context);
            SeedCategory5(context);
            SeedCategory7(context);
            //SeedCategory4(context);
            //SeedCategory6(context);
            //SeedCategory8(context);


        }
        private static void SeedCategory2(AppContext context)
        {
            int idCategory = 2;
            context.Products.AddOrUpdate(
              c => c.Id,
              new Product
              {
                  Id = 1,
                  Name = "Toca pro pai",
                  ComplementName = "Preta",
                  Type = "Camiseta",
                  Brand = "Estilo F.C.",
                  Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
                  Active = true,
                  ImageName = "toca-pro-pai-preta.png",
                  IdProductCategory = idCategory,
                  IdPrice = 1,
                  IdManufacturingData = 1,
                  ManufacturingData = new ManufacturingData
                  {
                      Id = 1,
                      History = "A expressão 'Toca pro pai', surgiu nas quadras e campos de várzea e faz referência ao jogador de personalidade que pede a bola e desequilibra a partida.",
                      IdRatting = 1,
                      ColletionName = "Primeira Coleção",
                      ReleaseDate = new System.DateTime(2015, 10, 10),
                      Drawing = 30
                  },
                  Price = new Price()
                  {
                      Id = 1,
                      Cost = 15.50m,
                      OnSale = true,
                      Promotial = 69.90m,
                      Selling = 89.90m
                  }
              });

            context.Products.AddOrUpdate(
            c => c.Id,
            new Product
            {
                Id = 2,
                Name = "Toca pro pai",
                ComplementName = "Branca",
                Type = "Camiseta",
                Brand = "Estilo F.C.",
                Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
                Active = true,
                ImageName = "toca-pro-pai-branca.png",
                IdProductCategory = idCategory,
                IdPrice = 2,
                IdManufacturingData = 2,
                ManufacturingData = new ManufacturingData
                {
                    Id = 2,
                    History = "A expressão 'Toca pro pai', surgiu nas quadras e campos de várzea e faz referência ao jogador de personalidade que pede a bola e desequilibra a partida.",
                    IdRatting = 1,
                    ColletionName = "Primeira Coleção",
                    ReleaseDate = new System.DateTime(2015, 10, 10),
                    Drawing = 30
                },
                Price = new Price()
                {
                    Id = 2,
                    Cost = 15.50m,
                    OnSale = true,
                    Promotial = 69.90m,
                    Selling = 89.90m
                }
            });
        }
        private static void SeedCategory3(AppContext context)
        {

            int idCategory = 3;
            context.Products.AddOrUpdate(
              c => c.Id,
              new Product
              {
                  Id = 3,
                  Name = "Eu penso, você corre",
                  ComplementName = "Branca",
                  Type = "Camiseta",
                  Brand = "Estilo F.C.",
                  Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
                  Active = true,
                  ImageName = "eu-penso-voce-corre-branca.png",
                  IdProductCategory = idCategory,
                  IdPrice = 3,
                  IdManufacturingData = 3,
                  ManufacturingData = new ManufacturingData
                  {
                      Id = 3,
                      History = "O futebol está mudado, muita força fisica e pouco talento, somos contra isso, um craque sabe o que faz põem a bola pra correr, afinal somos apaixonados por futebol e não por atletismo.",
                      IdRatting = 1,
                      ColletionName = "Primeira Coleção",
                      ReleaseDate = new System.DateTime(2015, 10, 10),
                      Drawing = 30
                  },
                  Price = new Price()
                  {
                      Id = 3,
                      Cost = 15.50m,
                      OnSale = true,
                      Promotial = 69.90m,
                      Selling = 89.90m
                  }
              });
            context.Products.AddOrUpdate(
              c => c.Id,
              new Product
              {
                  Id = 4,
                  Name = "Eu penso, você corre",
                  ComplementName = "Vermelho",
                  Type = "Camiseta",
                  Brand = "Estilo F.C.",
                  Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
                  Active = true,
                  ImageName = "eu-penso-voce-corre-vermelha.png",
                  IdProductCategory = idCategory,
                  IdPrice = 4,
                  IdManufacturingData = 4,
                  ManufacturingData = new ManufacturingData
                  {
                      Id = 4,
                      History = "O futebol está mudado, muita força fisica e pouco talento, somos contra isso, um craque sabe o que faz põem a bola pra correr, afinal somos apaixonados por futebol e não por atletismo.",
                      IdRatting = 1,
                      ColletionName = "Primeira Coleção",
                      ReleaseDate = new System.DateTime(2015, 10, 10),
                      Drawing = 30
                  },
                  Price = new Price()
                  {
                      Id = 4,
                      Cost = 15.50m,
                      OnSale = true,
                      Promotial = 69.90m,
                      Selling = 89.90m
                  }
              });

        }
        private static void SeedCategory5(AppContext context)
        {

            int idCategory = 5;

            context.Products.AddOrUpdate(
              c => c.Id,
              new Product
              {
                  Id = 5,
                  Name = "Jogou onde parceiro",
                  ComplementName = "Preta",
                  Type = "Camiseta",
                  Brand = "Estilo F.C.",
                  Description = "Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
                  Active = true,
                  ImageName = "jogou-aonde-preta.png",
                  IdProductCategory = idCategory,
                  IdPrice = 5,
                  ManufacturingData = new ManufacturingData
                  {
                      Id = 5,
                      History = "Quem joga sabe que tem muita gente metida a jogador mas nunca jogou em lugar nenhum, nunca ganhou nada, dai surgiu a expressão 'Jogou onde parceiro ?', está camiseta foi feita para exaltar a humildade.",
                      IdRatting = 1,
                      ColletionName = "Primeira Coleção",
                      ReleaseDate = new System.DateTime(2015, 10, 10),
                      Drawing = 30
                  },
                  IdManufacturingData = 5,
                  Price = new Price()
                  {
                      Id = 5,
                      Cost = 15.50m,
                      OnSale = true,
                      Promotial = 69.90m,
                      Selling = 89.90m
                  }
              });

            context.Products.AddOrUpdate(
          c => c.Id,
          new Product
          {
              Id = 6,
              Name = "Jogou onde parceiro",
              ComplementName = "Azul",
              Type = "Camiseta",
              Brand = "Estilo F.C.",
              Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
              Active = true,
              ImageName = "jogou-aonde-azul-marinho.png",
              IdProductCategory = idCategory,
              IdPrice = 6,
              IdManufacturingData = 6,
              ManufacturingData = new ManufacturingData
              {
                  Id = 6,
                  History = " Quem joga sabe que tem muita gente metida a jogador mas nunca jogou em lugar nenhum, nunca ganhou nada, dai surgiu a expressão 'Jogou onde parceiro ?', está camiseta foi feita para exaltar a humildade.",
                  IdRatting = 1,
                  ColletionName = "Primeira Coleção",
                  ReleaseDate = new System.DateTime(2015, 10, 10),
                  Drawing = 30
              },
              Price = new Price()
              {
                  Id = 6,
                  Cost = 15.50m,
                  OnSale = true,
                  Promotial = 69.90m,
                  Selling = 89.90m
              }
          });
        }


        private static void SeedCategory7(AppContext context)
        {
            int idCategory = 7;
            context.Products.AddOrUpdate(
              c => c.Id,
              new Product
              {
                  Id = 7,
                  Name = "10&Faixa",
                  ComplementName = "Branca",
                  Type = "Camiseta",
                  Brand = "Estilo F.C.",
                  Description = "Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
                  Active = true,
                  ImageName = "10efaixa-branca.png",
                  IdProductCategory = idCategory,
                  IdManufacturingData = 7,
                      ManufacturingData = new ManufacturingData
               {
                  Id = 7,
                  History = "O capitão de um time é um membro escolhido para ser para ser seu lider, já a camisa 10 é a que mais atrai a atenção, é a camisa que impõe repeito, geralmente é usada pelo craque do time.",
                  IdRatting = 1,
                  ColletionName = "Primeira Coleção",
                  ReleaseDate = new System.DateTime(2015, 10, 10),
                  Drawing = 30
               },
                  IdPrice = 7,
                  Price = new Price()
                  {
                      Id = 7,
                      Cost = 15.50m,
                      OnSale = true,
                      Promotial = 69.90m,
                      Selling = 89.90m
                  }
              });

            context.Products.AddOrUpdate(
           c => c.Id,
           new Product
           {
               Id = 8,
               Name = "10&Faixa",
               ComplementName = "Cinza",
               Type = "Camiseta",
               Brand = "Estilo F.C.",
               Description = "Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
               Active = true,
               ImageName = "10efaixa-cinza-clara.png",
               IdProductCategory = idCategory,
               IdPrice = 8,
         
               Price = new Price()
               {
                   Id = 8,
                   Cost = 15.50m,
                   OnSale = true,
                   Promotial = 69.90m,
                   Selling = 89.90m
               },
               IdManufacturingData = 8,
               ManufacturingData = new ManufacturingData
               {
                  Id = 8,
                  History = "O capitão de um time é um membro escolhido para ser para ser seu lider, já a camisa 10 é a que mais atrai a atenção, é a camisa que impõe repeito, geralmente é usada pelo craque do time.",
                  IdRatting = 1,
                  ColletionName = "Primeira Coleção",
                  ReleaseDate = new System.DateTime(2015, 10, 10),
                  Drawing = 30
               }


           });


        }

        //      private static void SeedCategory8(AppContext context)
        //      {
        //          int idCategory = 8;

        //          context.Products.AddOrUpdate(
        //c => c.Id,
        //new Product
        //{
        //    Id = 9,
        //    Name = "Estilo F.C.",
        //    ComplementName = "Branca",
        //    Type = "Camiseta",
        //    Brand = "Estilo F.C.",
        //    Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
        //    Active = true,
        //    ImageName = "Estilo F.C..png",
        //    IdProductCategory = idCategory,
        //    IdPrice = 9,
        //    Price = new Price()
        //    {
        //        Id = 9,
        //        Cost = 15.50m,
        //        OnSale = false,
        //        Promotial = 0,
        //        Selling = 59.90m
        //    }
        //});

        //      private static void SeedCategory6(AppContext context)
        //      {

        //          int idCategory = 6;
        //          context.Products.AddOrUpdate(
        //            c => c.Id,
        //            new Product
        //            {
        //                Id = 10,
        //                Name = "Meto a mala",
        //                ComplementName = "",
        //                Type = "Camiseta",
        //                Brand = "Estilo F.C.",
        //                Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
        //                Active = true,
        //                ImageName = "meto-a-mala.png",
        //                IdProductCategory = idCategory,
        //                IdPrice = 10,
        //                Price = new Price()
        //                {
        //                    Id = 10,
        //                    Cost = 15.50m,
        //                    OnSale = false,
        //                    Promotial = 0,
        //                    Selling = 59.90m
        //                }
        //            });
        //      }
        //      private static void SeedCategory4(AppContext context)
        //      {

        //          int idCategory = 4;
        //          context.Products.AddOrUpdate(
        //            c => c.Id,
        //            new Product
        //            {
        //                Id = 11,
        //                Name = "Eu estou aqui.",
        //                ComplementName = "",
        //                Type = "Camiseta",
        //                Brand = "Estilo F.C.",
        //                Description = " Camiseta 100% algodão malha penteada, tecido de toque extremamente macio e alta durabilidade.",
        //                Active = true,
        //                ImageName = "eu-estou-aqui.png",
        //                IdProductCategory = idCategory,
        //                IdPrice = 11,
        //                Price = new Price()
        //                {
        //                    Id = 11,
        //                    Cost = 15.50m,
        //                    OnSale = false,
        //                    Promotial = 0,
        //                    Selling = 59.90m
        //                }
        //            });
        //      }


        private static void SeedGender(AppContext context)
        {
            context.Gender.AddOrUpdate(
                c => c.Id,
                new Gender { Id = 1, Name = "Masculino" },
                new Gender { Id = 2, Name = "Feminino" });
        }
        private static void SeedSize(AppContext context)
        {
            context.Sizes.AddOrUpdate(
                c => c.Id,
                new Size { Id = 1, Name = "Pequeno", Code = "P" },
                new Size { Id = 2, Name = "Médio", Code = "M" },
                new Size { Id = 3, Name = "Grande", Code = "G" }
                );

        }
        private static void SeedContactForm(AppContext context)
        {
            context.ContactForms.AddOrUpdate(
                c => c.Id,
                new ContactForm { Id = 1, Name = "WhatsApp" },
                new ContactForm { Id = 2, Name = "Email" },
                new ContactForm { Id = 3, Name = "Telefone" },
                new ContactForm { Id = 4, Name = "SMS" }
                );

        }
        private static void SeedColors(AppContext context)
        {
            context.Colors.AddOrUpdate(
                c => c.Id,
                new Color { Id = 1, Name = "Preto" },
                new Color { Id = 2, Name = "Branco" },
                new Color { Id = 3, Name = "Azul marinho" },
                new Color { Id = 4, Name = "Vermelho" },
                new Color { Id = 5, Name = "Cinza" }
                );

        }
        private static void SeedPaymentType(AppContext context)
        {
            context.PaymentsType.AddOrUpdate(
                c => c.Id,
                new PaymentType { Id = 1, Key = "MONEY", Description = "Dinheiro" },
                new PaymentType { Id = 2, Key = "CREDIT_CARD", Description = "Cartão de Crédito" },
                new PaymentType { Id = 3, Key = "DEBIT_CARD", Description = "Cartão de Débito" },
                new PaymentType { Id = 4, Key = "SODEXO", Description = "Sodexo" },
                new PaymentType { Id = 5, Key = "VISA VALE", Description = "Visa Vale" }
                );
        }
        private static void SeedRattingType(AppContext context)
        {
            context.RattingType.AddOrUpdate(
                c => c.Id,
                new RattingType { Id = 1, Key = "R", Name = "Raro" },
                new RattingType { Id = 2, Key = "I", Name = "Incomum" },
                new RattingType { Id = 3, Key = "C", Name = "Comum" }
                );
        }

        private static void SeedManufacturingData(AppContext context)
        {


        }
    }
}
