public class Indumentaria {
    public IFormFile Medias {get; private set;}
    public IFormFile Pantalon {get; private set;}
    public IFormFile Camiseta {get; private set;}

    public Indumentaria(IFormFile medias, IFormFile pantalon, IFormFile camiseta) {
        Medias = medias;
        Pantalon = pantalon;
        Camiseta = camiseta;
    }
}