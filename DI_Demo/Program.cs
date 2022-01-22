using DI_Demo.Model.DI.BL;
using DI_Demo.Model.LifeTime;
using DI_Demo.Model.Second.BL;
using DI_Demo.Model.Second.DAL;
using static DI_Demo.Model.LifeTime.LifeTimeSample;

var builder = WebApplication.CreateBuilder(args);


//使用DI 為Inserface注入實作
builder.Services.AddSingleton<IProductBL, ProductBL>(); // Product BL
builder.Services.AddSingleton<IProductDAL, ProductDAL>(); // Product DAL

#region DI 生命週期 範例
builder.Services.AddTransient<ISampleTransient, Sample>(); //Transient
builder.Services.AddScoped<ISampleScoped, Sample>(); //Scoped
builder.Services.AddSingleton<ISampleSingleton, Sample>(); //Singleton 
 
#endregion


builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
