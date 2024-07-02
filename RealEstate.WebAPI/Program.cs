using RealEstate.Bll.DependencyResolvers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//Controller'ları ekledik.
builder.Services.AddControllers(); 
//API Explorer'ı ekledik.
builder.Services.AddEndpointsApiExplorer(); 
//Swagger'ı ekledik.
builder.Services.AddSwaggerGen(); 

//Dependency Injection işlemleri
builder.Services.AddIdentityService();
builder.Services.AddCustomContextService(); 
builder.Services.AddRepositoryManagerServices();

//Session için gerekli ayarlamalar
//Session verilerinin bellekte tutulmasını sağlar.
builder.Services.AddDistributedMemoryCache(); 
//Session ayarlarını yapar.
builder.Services.AddSession(x =>
{
    //Session süresi 2 dakika olarak ayarlandı.
    x.IdleTimeout = TimeSpan.FromMinutes(2);
    //Cookie'nin sadece HTTP üzerinden erişilebilir olmasını sağlar.
    x.Cookie.HttpOnly = true; 
    //Cookie'nin zorunlu olmasını sağlar.
    x.Cookie.IsEssential = true; 
}); 



WebApplication app = builder.Build();

//Development ortamında Swagger'ı kullanmak için ekledik.
if (app.Environment.IsDevelopment()) 
{
    //Swagger'ın kullanılabilmesi için gerekli ayarlamaları yaptık.
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting(); // Routing middleware'ini ekledik.

// CORS politikasını kullanın
app.UseCors("RealEstateClient");

app.UseAuthorization(); //Yetkilendirme işlemleri için ekledik.

app.UseSession(); //Session'ı kullanmak için ekledik.

app.MapControllers(); //Controller'ları eşleştirdik.

app.Run();
