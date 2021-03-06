// Do not edit this file manually it is auto-generated during the build based on the .resx file for this project.
namespace System
{
    internal static partial class SR
    {
#pragma warning disable 0414
        private const string s_resourcesName = "System.Collections.Immutable.resources"; // assembly Name + .resources
#pragma warning restore 0414

#if !DEBUGRESOURCES
        internal static string ArrayInitializedStateNotEqual {
              get { return SR.GetResourceString("ArrayInitializedStateNotEqual", null); }
        }
        internal static string ArrayLengthsNotEqual {
              get { return SR.GetResourceString("ArrayLengthsNotEqual", null); }
        }
        internal static string CannotFindOldValue {
              get { return SR.GetResourceString("CannotFindOldValue", null); }
        }
        internal static string CapacityMustBeGreaterThanOrEqualToCount {
              get { return SR.GetResourceString("CapacityMustBeGreaterThanOrEqualToCount", null); }
        }
        internal static string CapacityMustEqualCountOnMove {
              get { return SR.GetResourceString("CapacityMustEqualCountOnMove", null); }
        }
        internal static string CollectionModifiedDuringEnumeration {
              get { return SR.GetResourceString("CollectionModifiedDuringEnumeration", null); }
        }
        internal static string DuplicateKey {
              get { return SR.GetResourceString("DuplicateKey", null); }
        }
        internal static string InvalidEmptyOperation {
              get { return SR.GetResourceString("InvalidEmptyOperation", null); }
        }
        internal static string InvalidOperationOnDefaultArray {
              get { return SR.GetResourceString("InvalidOperationOnDefaultArray", null); }
        }
#else
        internal static string ArrayInitializedStateNotEqual {
              get { return SR.GetResourceString("ArrayInitializedStateNotEqual", @"Object is not a array with the same initialization state as the array to compare it to."); }
        }
        internal static string ArrayLengthsNotEqual {
              get { return SR.GetResourceString("ArrayLengthsNotEqual", @"Object is not a array with the same number of elements as the array to compare it to."); }
        }
        internal static string CannotFindOldValue {
              get { return SR.GetResourceString("CannotFindOldValue", @"Cannot find the old value"); }
        }
        internal static string CapacityMustBeGreaterThanOrEqualToCount {
              get { return SR.GetResourceString("CapacityMustBeGreaterThanOrEqualToCount", @"Capacity was less than the current Count of elements."); }
        }
        internal static string CapacityMustEqualCountOnMove {
              get { return SR.GetResourceString("CapacityMustEqualCountOnMove", @"MoveToImmutable can only be performed when Count equals Capacity."); }
        }
        internal static string CollectionModifiedDuringEnumeration {
              get { return SR.GetResourceString("CollectionModifiedDuringEnumeration", @"Collection was modified; enumeration operation may not execute."); }
        }
        internal static string DuplicateKey {
              get { return SR.GetResourceString("DuplicateKey", @"An element with the same key but a different value already exists. Key: {0}"); }
        }
        internal static string InvalidEmptyOperation {
              get { return SR.GetResourceString("InvalidEmptyOperation", @"This operation does not apply to an empty instance."); }
        }
        internal static string InvalidOperationOnDefaultArray {
              get { return SR.GetResourceString("InvalidOperationOnDefaultArray", @"This operation cannot be performed on a default instance of ImmutableArray<T>.  Consider initializing the array, or checking the ImmutableArray<T>.IsDefault property."); }
        }

#endif
    }
}
