using AutoMapper;
using AutoMapper_Example;

var config = new MapperConfiguration(cfg =>
{
    // Automapper konfigurasyonu yapilir
    cfg.CreateMap<Customer, CustomerDTO>();
});

// Nesneler donusturulur
IMapper mapper = config.CreateMapper();

var customer = new Customer
{
    Id = 1,
    FirstName = "Mauro",
    LastName = "Icardi",
    Email = "mauroicardi@gmail.com"

};

// Customer nesnesi  CustomerDTO'ya donusturur.

var customerDTO = mapper.Map<CustomerDTO>(customer);

Console.WriteLine($"Musteri id : {customerDTO.Id} " );
Console.WriteLine($"Musteri Adi : {customerDTO.FirstName} ");
Console.WriteLine($"Musteri Adi : {customerDTO.LastName} ");
Console.WriteLine($"Musteri id : {customerDTO.Email} ");




