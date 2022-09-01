# ExempelProject_9_1

Skapa ProductController
	konstruktor för repository och logger
	Route
	GET med try catch

Skapa OrdersController
	samma princip som i ProductController
	För GetAllOrders generate method och följa den med f12
	Method finns i IExempelRepository
	I ExempelRepository behöver ni implementera interface efter ni har gjort ändringar.
I ExempelRepository kommer ni att ha 
	public IEnumerable<Order> GetAllOrders
	obs: om fel uppstår kolla om ni har razor runtime compilation i Startup
	lägga till --> .AddNewtonsoftJson();
	NuGet --> mvc newtonsoft
	configurera den i Startup

GetOrderById

	OrdersController
	lägga till HttpGet
	Generate method 
	ExempelRepository implement interface


Lägga till nya product via POSTMAN
	POST method i OrdersController
	Testa genom att skicka in data via POSTMAN
	Attribute FromBody
	Generate method for AddEntity
	AddEntity
	Implement interface i ExempelRepository
	
Validation och ViewModels

	ContactViewModel
	HttpPost - newOrder
	Testa i POSTMAN

AutoMapper
	NuGet package - AutoMapper Dependency Injection
	MappingProfile 
	Använda samma metod for collections i OrdersController - GetAllOrders
















 
