using Libreria.Shared.Models; 

public class CarroServicio {
    public List<Libro> LibrosSeleccionados = new();
    public float precioTotal = 0;

    public bool EnCarrito(long ISBN){
        var libro = LibroServicio.Catalogo.Where(i => i.ISBN == ISBN).FirstOrDefault();
        return LibrosSeleccionados.Contains(libro);
    }

    public void VaciarCarrito() {
        if(LibrosSeleccionados.Any()){
            LibrosSeleccionados.Clear();
        }
    }

    public void AgregarAlCarrito(long ISBN) {
        var libro = LibroServicio.Catalogo.Where(i => i.ISBN == ISBN).FirstOrDefault();
        if(LibrosSeleccionados.Contains(libro) is false) {
            LibrosSeleccionados.Add(libro);
            precioTotal += libro.Precio;
        }
    }
    public void BorrarDelCarrito(long ISBN) {
        var libro = LibrosSeleccionados.Where(i => i.ISBN == ISBN).FirstOrDefault();
        if(LibrosSeleccionados.Contains(libro) is true) {
            LibrosSeleccionados.Remove(libro);
            precioTotal -= libro.Precio;
        }
    }
}

