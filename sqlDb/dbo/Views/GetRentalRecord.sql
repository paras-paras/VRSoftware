CREATE VIEW [dbo].[GetRentalRecord]
	AS 
	SELECT r.Id as RentalId, r.CustomerId,r.IsReturned,r.IssuedDate,r.ReturnedDate,r.VideoId,
	c.Id as CustId , c.FirstName,c.LastName,c.Phone,c.Address,
	v.Id as VidId, v.Cost,v.Description,v.Genre,v.ReleaseDate,v.Title
	  FROM Rental r join Customer c on r.CustomerId=c.Id 
	join Video v on v.Id =r.VideoId
	order by r.IssuedDate asc OFFSET 0 ROWS