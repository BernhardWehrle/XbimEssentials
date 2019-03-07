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
namespace Xbim.IfcRail.BuildingControlsDomain
{
	public partial class IfcFlowInstrumentType : IExpressValidatable
	{
		public enum IfcFlowInstrumentTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcFlowInstrumentTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcFlowInstrumentTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcFlowInstrumentTypeEnum.USERDEFINED) || ((PredefinedType == IfcFlowInstrumentTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Xbim.IfcRail.BuildingControlsDomain.IfcFlowInstrumentType>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcFlowInstrumentType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcFlowInstrumentTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFlowInstrumentType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}