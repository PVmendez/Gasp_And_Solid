
using System;

namespace Proyecto_Gasp_And_Solid
{
    public class ConsolePrinter
    {
        Recipe recipe = new Recipe();
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
        
    }
    
}