static public class Equipos {
    public static List<string> ListaEquipos {get;  set;}
    public static List<string> ListaMedias {get;  set;}
    public static List<string> ListaPantalones {get;  set;}
    public static List <string> ListaRemeras {get;  set;}
    public static Dictionary <string, Indumentaria> EquiposIndumentaria {get;  set;}

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item) {



    EquiposIndumentaria.Add(equipoSeleccionado, item);
    return true;
    }

}