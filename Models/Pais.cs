public class Pais
{
    public string Nombre { get; private set; }
    public string ImgBandera { get; private set; }
    public int Poblacion { get; private set; }
    public DateTime FechaIndependencia { get; private set; }
    public string AtractivosTuristicos { get; private set; }

    public Pais(string nombre, string imgBandera, int poblacion, DateTime fechaIndependencia, string atractivosTuristicos)
    {
        Nombre = nombre;
        ImgBandera = imgBandera;
        Poblacion = poblacion;
        FechaIndependencia = fechaIndependencia;
        AtractivosTuristicos = atractivosTuristicos;
    }
}