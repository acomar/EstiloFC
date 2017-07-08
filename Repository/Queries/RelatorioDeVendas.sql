select  
ord.id,
usr.email,
sts.[description],
ord.datecreated,
pdt.Name,
clr.Name,
sze.Name,
itm.Quantity,
itm.UnitPrice,
itm.quantity * itm.UnitPrice as total
from [order] ord
inner join [user] usr on usr.id = ord.iduser
inner join [orderitem] itm on ord.id = itm.idOrder
inner join [product] pdt on pdt.Id = itm.idProduct
inner join [size] sze on sze.id = itm.idSize
inner join [color] clr on clr.id = itm.idColor
inner join [orderstatus] sts on ord.idOrderStatus = sts.id


select 
hty.id,
pdt.Name,
clr.Name,
sze.Name,
hty.Quantity
from stockHistory hty
inner join [product] pdt on pdt.Id = hty.idProduct
inner join [size] sze on sze.id = hty.idSize
inner join [color] clr on clr.id = hty.idColor

select 
pdt.Name,
sze.Name,
stk.Quantity 
from stock stk
inner join [product] pdt on pdt.Id = stk.idProduct
inner join [size] sze on sze.id = stk.idSize
inner join [color] clr on clr.id = stk.idColor