// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.QuantityResource
{
	public partial class @IfcPhysicalComplexQuantity : IIfcPhysicalComplexQuantity
	{
		IEnumerable<IIfcPhysicalQuantity> IIfcPhysicalComplexQuantity.HasQuantities 
		{ 
			get
			{
				foreach (var member in HasQuantities)
				{
					yield return member as IIfcPhysicalQuantity;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel IIfcPhysicalComplexQuantity.Discrimination 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Discrimination);
			} 
			set
			{
				Discrimination = new MeasureResource.IfcLabel(value);
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPhysicalComplexQuantity.Quality 
		{ 
			get
			{
				if (!Quality.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Quality.Value);
			} 
			set
			{
				Quality = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPhysicalComplexQuantity.Usage 
		{ 
			get
			{
				if (!Usage.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Usage.Value);
			} 
			set
			{
				Usage = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}