//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
/*ES LA CLASE ENCARGADA DE CREAR LA RECETA CON SUS PASOS Y IMPRIMIRLA
IMPLEMENTA STEP Y PRODUCT*/
namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }

        //expert (clase maestra es recipe ya que implemeta product y step quien implementa equipment)
        public double GetProductionCost()
        {
          Double costoInsumos = 0;
          Double costoEquipment = 0; 
          Double total = 0;
          foreach(Step step in this.steps) 
          {
            costoInsumos = costoInsumos + step.Input.UnitCost;
            costoEquipment = costoEquipment + (step.Equipment.HourlyCost * (step.Time/60));

          }
          total = costoEquipment + costoInsumos;

          return total;
        }
    }
}