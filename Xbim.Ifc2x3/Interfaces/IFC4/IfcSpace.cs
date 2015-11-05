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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcSpace : IIfcSpace
	{
		Ifc4.ProductExtension.IfcSpaceTypeEnum? IIfcSpace.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
                return null;
				//##
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSpace.ElevationWithFlooring 
		{ 
			get
			{
				if (!ElevationWithFlooring.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(ElevationWithFlooring.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcSpatialElement.LongName 
		{ 
			get
			{
				//## Handle return of LongName for which no match was found
                return !Name.HasValue ? null : new Ifc4.MeasureResource.IfcLabel(Name.Value);
				//##
			} 
		}
		IEnumerable<IIfcRelCoversSpaces> IIfcSpace.HasCoverings 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversSpaces>(e => (e.RelatingSpace as IfcSpace) == this);
			} 
		}
		IEnumerable<IIfcRelSpaceBoundary> IIfcSpace.BoundedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelSpaceBoundary>(e => (e.RelatingSpace as IfcSpace) == this);
			} 
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialElement.ContainsElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcSpace) == this);
			} 
		}
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialElement.ServicedBySystems 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this));
			} 
		}
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialElement.ReferencesElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcSpace) == this);
			} 
		}

	//## Custom code
	//##
	}
}