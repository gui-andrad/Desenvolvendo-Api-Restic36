using System.ComponentModel.DataAnnotations;

public class Pedido{
    
    public int PedidoId{get ; set;}

   public int QuantidadeProduto{get ; set;}

   [Required(ErrorMessage = "O status do pedido é obrigatório.")]
   [StringLength(12, ErrorMessage ="O status do pedido não pode ter mais de 12 caracteres.")]
   public required String Status{get ; set;}

   public int ClienteId{get;set;}
}