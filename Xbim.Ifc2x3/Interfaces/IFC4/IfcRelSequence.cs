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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelSequence : IIfcRelSequence
	{
		IIfcProcess IIfcRelSequence.RelatingProcess 
		{ 
			get
			{
				return RelatingProcess;
			} 
		}
		IIfcProcess IIfcRelSequence.RelatedProcess 
		{ 
			get
			{
				return RelatedProcess;
			} 
		}
		IIfcLagTime IIfcRelSequence.TimeLag 
		{ 
			get
			{
				//## Handle return of TimeLag for which no match was found
				//TODO: Handle return of TimeLag for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.ProcessExtension.IfcSequenceEnum? IIfcRelSequence.SequenceType 
		{ 
			get
			{
				switch (SequenceType)
				{
					case IfcSequenceEnum.START_START:
						return Ifc4.ProcessExtension.IfcSequenceEnum.START_START;
					
					case IfcSequenceEnum.START_FINISH:
						return Ifc4.ProcessExtension.IfcSequenceEnum.START_FINISH;
					
					case IfcSequenceEnum.FINISH_START:
						return Ifc4.ProcessExtension.IfcSequenceEnum.FINISH_START;
					
					case IfcSequenceEnum.FINISH_FINISH:
						return Ifc4.ProcessExtension.IfcSequenceEnum.FINISH_FINISH;
					
					case IfcSequenceEnum.NOTDEFINED:
						return Ifc4.ProcessExtension.IfcSequenceEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcRelSequence.UserDefinedSequenceType 
		{ 
			get
			{
				//## Handle return of UserDefinedSequenceType for which no match was found
                return null;
				//##
			} 
		}

	//## Custom code
	//##
	}
}