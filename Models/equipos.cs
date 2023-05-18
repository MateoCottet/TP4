static public class Equipos {
    public static List<string> ListaEquipos {get;  set;}
    public static List<IFormFile> ListaMedias {get;  set;}
    public static List<IFormFile> ListaPantalones {get;  set;}
    public static List <IFormFile> ListaRemeras {get;  set;}
    public static Dictionary <string, Indumentaria> EquiposIndumentaria {get;  set;}

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item) {

    if (equipoSeleccionado == null || item == null)
    {
        return false;
    }

    if (EquiposIndumentaria.ContainsKey(equipoSeleccionado))
    {
        return false;
    }

    EquiposIndumentaria.Add(equipoSeleccionado, item);
    return true;
    }

}