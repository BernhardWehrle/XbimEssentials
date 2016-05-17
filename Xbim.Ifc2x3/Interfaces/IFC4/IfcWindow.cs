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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcWindow : IIfcWindow
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindow.OverallHeight 
		{ 
			get
			{
				if (!OverallHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallHeight.Value);
			} 
			set
			{
				OverallHeight = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindow.OverallWidth 
		{ 
			get
			{
				if (!OverallWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallWidth.Value);
			} 
			set
			{
				OverallWidth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
		private  Ifc4.Interfaces.IfcWindowTypeEnum? _predefinedType;

		Ifc4.Interfaces.IfcWindowTypeEnum? IIfcWindow.PredefinedType 
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
		Ifc4.Interfaces.IfcWindowTypePartitioningEnum? IIfcWindow.PartitioningType 
		{ 
			get
			{
				//## Handle return of PartitioningType for which no match was found
                return Ifc4.Interfaces.IfcWindowTypePartitioningEnum.NOTDEFINED;
				//##
			} 
			set
			{
				//## Handle setting of PartitioningType for which no match was found
				//TODO: Handle setting of PartitioningType for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcWindow.UserDefinedPartitioningType 
		{ 
			get
			{
				//## Handle return of UserDefinedPartitioningType for which no match was found
                return null;
				//##
			} 
			set
			{
				//## Handle setting of UserDefinedPartitioningType for which no match was found
				//TODO: Handle setting of UserDefinedPartitioningType for which no match was found
				throw new System.NotImplementedException();
				//##
				
			}
		}
	//## Custom code

        /// <summary>
	    /// Returns if the door is external
	    /// </summary>
	    /// <returns></returns>
	    public Xbim.Ifc4.MeasureResource.IfcBoolean? IsExternal
        {
            get
            {
                var val = GetPropertySingleNominalValue("Pset_WindowCommon", "IsExternal");
                if (val is Xbim.Ifc2x3.MeasureResource.IfcBoolean)
                    return new Xbim.Ifc4.MeasureResource.IfcBoolean((Xbim.Ifc2x3.MeasureResource.IfcBoolean)val);
                return new Xbim.Ifc4.MeasureResource.IfcBoolean(false); //default is to return false
            }
        }

	    /// <summary>
	    /// Returns the Reference ID for this specified type in this project (e.g. type 'A-1'), if known
	    /// </summary>
	    /// <returns></returns>
	    public Xbim.Ifc4.MeasureResource.IfcIdentifier? Reference
        {
            get
            {
                var val = GetPropertySingleNominalValue("Pset_WindowCommon", "Reference ");
                if (val is Xbim.Ifc2x3.MeasureResource.IfcIdentifier)
                    return new Xbim.Ifc4.MeasureResource.IfcIdentifier((Xbim.Ifc2x3.MeasureResource.IfcIdentifier)val);
                return null;
            }
        }

	    /// <summary>
	    /// Returns the fire rating if defined
	    /// </summary>
	    /// <returns></returns>
	    public Xbim.Ifc4.MeasureResource.IfcLabel? FireRating
        {
            get
            {
                var val = GetPropertySingleNominalValue("Pset_WindowCommon", "FireRating ");
                if (val is Xbim.Ifc2x3.MeasureResource.IfcLabel)
                    return new Xbim.Ifc4.MeasureResource.IfcLabel((Ifc2x3.MeasureResource.IfcLabel)val);
                return null;
            }
        }
	//##
	}
}