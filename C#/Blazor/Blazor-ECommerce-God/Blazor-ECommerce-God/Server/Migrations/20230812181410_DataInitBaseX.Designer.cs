﻿// <auto-generated />
using Blazor_ECommerce_God.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorECommerceGod.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230812181410_DataInitBaseX")]
    partial class DataInitBaseX
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blazor_ECommerce_God.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "La trama describe la historia del maestro jedi Qui-Gon Jinn y de su aprendiz Obi-Wan Kenobi, que escoltan y protegen a la Reina Amidala desde su planeta Naboo hasta Coruscant con la esperanza de encontrar una salida pacífica a un conflicto comercial interplanetario a gran escala. También trata del joven Anakin Skywalker antes de convertirse en Jedi, presentado como un esclavo con un potencial de la Fuerza inusualmente fuerte, y debe lidiar con el misterioso regreso de los Sith.",
                            ImageUrl = "https://pics.filmaffinity.com/Star_Wars_Episodio_I_La_amenaza_fantasma-434398792-large.jpg",
                            Price = 18.99m,
                            Title = "Star Wars: Episodio I - La amenaza fantasma"
                        },
                        new
                        {
                            Id = 2,
                            Description = "La cinta transcurre en el año 1985, una época en la que el joven Marty McFly lleva una existencia anónima con su novia Jennifer. Los únicos problemas son su familia en crisis y un director al que le encantaría expulsarle del instituto, por lo que deberá hacer todo lo que esté en su mano para revertir esa situación y aparentar total normalidad. Amigo del excéntrico profesor Emmett Brown, una noche le acompaña a probar su nuevo experimento: viajar en el tiempo usando un DeLorean modificado. Sin duda alguna, se trata de una investigación realmente arriesgada pero que puede aportarles un enorme éxito en el futuro. No obstante, la prueba sale aún peor de lo esperado: unos traficantes de armas llegan y asesinan al científico. Marty se refugia en el coche y aparece transportado hasta 1955. Allí impide, a su pesar, que sus padres se conozcan y se verá en la obligación de hacer lo necesario para que vuelvan juntos. De lo contrario, él jamás podrá regresar al momento actual debido a que nunca habrá existido.",
                            ImageUrl = "https://es.web.img3.acsta.net/c_310_420/pictures/14/03/11/10/30/351336.jpg",
                            Price = 9.99m,
                            Title = "Regreso al futuro"
                        },
                        new
                        {
                            Id = 3,
                            Description = "En 1936 el arqueólogo estadounidense Indiana Jones viaja a un templo peruano para recuperar una estatuilla, sin embargo es interceptado por René Belloq, un colega con quien tiene una rivalidad. Tras una persecución por integrantes de una tribu salvaje, Belloq se hace con la estatuilla y Jones escapa a bordo de un hidroavión. De vuelta en Estados Unidos, un par de agentes de inteligencia del ejército le informan a Jones que, al interceptar unos telegramas nazis, se percataron de que las fuerzas alemanas se encuentran excavando en algún sitio de Tanis, Egipto. En uno de los telegramas se menciona a Abner Ravenwood, el antiguo mentor de Indiana. Con esta información, el aventurero deduce que los nazis buscan el Arca de la Alianza para volverse «invencibles», así que acepta involucrarse en una misión para impedirlo.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfH2ZZG2qTi0-MyBvH1qCiHhnU-Is4EcgXKLX-uvIQ&s",
                            Price = 14.99m,
                            Title = " Indiana Jones y los cazadores del arca perdida"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
