using System.ComponentModel.DataAnnotations;

public class Pedido{
    
    public int Id{get ; set;}

   public int QuantidadeProduto{get ; set;}

   [Required(ErrorMessage = "O status do pedido é obrigatório.")]
   [StringLength(12, ErrorMessage ="O status do pedido não pode ter mais de 12 caracteres.")]
   public required String Status{get ; set;}

//referenciar o id do cliente como?


}