using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;

// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.IfcRail.SharedBldgElements
{
	public partial class IfcShadingDevice : IExpressValidatable
	{
		public enum IfcShadingDeviceClause
		{
			CorrectPredefinedType,
			CorrectTypeAssigned,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcShadingDeviceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcShadingDeviceClause.CorrectPredefinedType:
						retVal = !(Functions.EXISTS(PredefinedType)) || (PredefinedType != IfcShadingDeviceTypeEnum.USERDEFINED) || ((PredefinedType == IfcShadingDeviceTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
					case IfcShadingDeviceClause.CorrectTypeAssigned:
						retVal = (Functions.SIZEOF(IsTypedBy) == 0) || (Functions.TYPEOF(this/* as IfcObject*/.IsTypedBy.ItemAt(0).RelatingType).Contains("IFCSHADINGDEVICETYPE"));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Xbim.IfcRail.SharedBldgElements.IfcShadingDevice>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcShadingDevice.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcShadingDeviceClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcShadingDevice.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcShadingDeviceClause.CorrectTypeAssigned))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcShadingDevice.CorrectTypeAssigned", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}