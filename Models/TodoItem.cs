using System.ComponentModel.DataAnnotations;

namespace QuickTodos.Models;

public class TodoItem
{

    public long Id { get; set; }
    [Required]
    [StringLength(25, ErrorMessage = "Title length can't be more than 25.")]
    public string? Title { get; set; }
    public bool Completed { get; set; }

     public TodoItem()
    { 
        Completed = false;
    }
}