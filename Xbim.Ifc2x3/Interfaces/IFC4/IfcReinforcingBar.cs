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
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcReinforcingBar : IIfcReinforcingBar
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.NominalDiameter 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter);
			} 
			set
			{
				NominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 default(MeasureResource.IfcPositiveLengthMeasure) ;
				
			}
		}
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcReinforcingBar.CrossSectionArea 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(CrossSectionArea);
			} 
			set
			{
				CrossSectionArea = value.HasValue ? 
					new MeasureResource.IfcAreaMeasure(value.Value) :  
					 default(MeasureResource.IfcAreaMeasure) ;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.BarLength 
		{ 
			get
			{
				if (!BarLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(BarLength.Value);
			} 
			set
			{
				BarLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		private  Ifc4.Interfaces.IfcReinforcingBarTypeEnum? _predefinedType;

		Ifc4.Interfaces.IfcReinforcingBarTypeEnum? IIfcReinforcingBar.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", byte.MaxValue);
				
			}
		}
		Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum? IIfcReinforcingBar.BarSurface 
		{ 
			get
			{
				switch (BarSurface)
				{
					case ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.PLAIN:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN;
					
					case ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.TEXTURED:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
	//## Custom code
	//##
	}
}