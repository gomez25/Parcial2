namespace Parcial2.Models
{
    public abstract class FiguraModel
    {
        public string Nombre { get; set; }
        public bool Validar { get; set; } //true: area false: perimetro
        public float Perimetro { get; set; }
        public float Area { get; set; }
    }
}
