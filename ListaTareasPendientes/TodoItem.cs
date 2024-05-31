namespace ListaTareasPendientes
{
    // Define una clase que representa un elemento de una lista de tareas pendientes
    public class TodoItem
    {
        // Título de la tarea pendiente
        public string? Title { get; set; }
        // Indica si la tarea está completada o no
        public bool IsDone { get; set; } = false;
    }
}