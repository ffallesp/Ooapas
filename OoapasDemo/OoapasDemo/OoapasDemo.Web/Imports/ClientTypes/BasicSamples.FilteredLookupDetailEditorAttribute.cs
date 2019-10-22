using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace OoapasDemo.BasicSamples {
    public partial class FilteredLookupDetailEditorAttribute : CustomEditorAttribute {
        public const string Key = "OoapasDemo.BasicSamples.FilteredLookupDetailEditor";

        public FilteredLookupDetailEditorAttribute()
            : base(Key) {
        }
    }
}
