using System;
using System.ComponentModel;
using System.Web;
using System.Web.Util;

namespace Pitchfork.Web.Util {
    /// <summary>
    /// A RequestValidator that performs no work.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class NoopRequestValidator : RequestValidator {
        protected override bool IsValidRequestString(HttpContext context, string value, RequestValidationSource requestValidationSource, string collectionKey, out int validationFailureIndex) {
            validationFailureIndex = 0;
            return true;
        }
    }
}
