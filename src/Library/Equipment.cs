//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
/*CREA EL EQUIPAMIENTO CON EL COSTO DE HORA Y UNA DESCRIPCION DE LO QUE VA HACER*/
namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
    }
}