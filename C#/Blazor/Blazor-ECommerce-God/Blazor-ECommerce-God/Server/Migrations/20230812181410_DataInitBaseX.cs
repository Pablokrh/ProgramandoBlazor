using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorECommerceGod.Server.Migrations
{
    /// <inheritdoc />
    public partial class DataInitBaseX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "La trama describe la historia del maestro jedi Qui-Gon Jinn y de su aprendiz Obi-Wan Kenobi, que escoltan y protegen a la Reina Amidala desde su planeta Naboo hasta Coruscant con la esperanza de encontrar una salida pacífica a un conflicto comercial interplanetario a gran escala. También trata del joven Anakin Skywalker antes de convertirse en Jedi, presentado como un esclavo con un potencial de la Fuerza inusualmente fuerte, y debe lidiar con el misterioso regreso de los Sith.", "https://pics.filmaffinity.com/Star_Wars_Episodio_I_La_amenaza_fantasma-434398792-large.jpg", 18.99m, "Star Wars: Episodio I - La amenaza fantasma" },
                    { 2, "La cinta transcurre en el año 1985, una época en la que el joven Marty McFly lleva una existencia anónima con su novia Jennifer. Los únicos problemas son su familia en crisis y un director al que le encantaría expulsarle del instituto, por lo que deberá hacer todo lo que esté en su mano para revertir esa situación y aparentar total normalidad. Amigo del excéntrico profesor Emmett Brown, una noche le acompaña a probar su nuevo experimento: viajar en el tiempo usando un DeLorean modificado. Sin duda alguna, se trata de una investigación realmente arriesgada pero que puede aportarles un enorme éxito en el futuro. No obstante, la prueba sale aún peor de lo esperado: unos traficantes de armas llegan y asesinan al científico. Marty se refugia en el coche y aparece transportado hasta 1955. Allí impide, a su pesar, que sus padres se conozcan y se verá en la obligación de hacer lo necesario para que vuelvan juntos. De lo contrario, él jamás podrá regresar al momento actual debido a que nunca habrá existido.", "https://es.web.img3.acsta.net/c_310_420/pictures/14/03/11/10/30/351336.jpg", 9.99m, "Regreso al futuro" },
                    { 3, "En 1936 el arqueólogo estadounidense Indiana Jones viaja a un templo peruano para recuperar una estatuilla, sin embargo es interceptado por René Belloq, un colega con quien tiene una rivalidad. Tras una persecución por integrantes de una tribu salvaje, Belloq se hace con la estatuilla y Jones escapa a bordo de un hidroavión. De vuelta en Estados Unidos, un par de agentes de inteligencia del ejército le informan a Jones que, al interceptar unos telegramas nazis, se percataron de que las fuerzas alemanas se encuentran excavando en algún sitio de Tanis, Egipto. En uno de los telegramas se menciona a Abner Ravenwood, el antiguo mentor de Indiana. Con esta información, el aventurero deduce que los nazis buscan el Arca de la Alianza para volverse «invencibles», así que acepta involucrarse en una misión para impedirlo.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfH2ZZG2qTi0-MyBvH1qCiHhnU-Is4EcgXKLX-uvIQ&s", 14.99m, " Indiana Jones y los cazadores del arca perdida" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
