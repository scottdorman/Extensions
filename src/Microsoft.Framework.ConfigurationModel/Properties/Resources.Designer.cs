// <auto-generated />
namespace Microsoft.Framework.ConfigurationModel
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Framework.ConfigurationModel.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Unable to commit because the following keys are missing from the configuration file: {0}.
        /// </summary>
        internal static string Error_CommitWhenKeyMissing
        {
            get { return GetString("Error_CommitWhenKeyMissing"); }
        }

        /// <summary>
        /// Unable to commit because the following keys are missing from the configuration file: {0}.
        /// </summary>
        internal static string FormatError_CommitWhenKeyMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_CommitWhenKeyMissing"), p0);
        }

        /// <summary>
        /// Unable to commit because a new key was added to the configuration file after last load operation. The newly added key is '{0}'.
        /// </summary>
        internal static string Error_CommitWhenNewKeyFound
        {
            get { return GetString("Error_CommitWhenNewKeyFound"); }
        }

        /// <summary>
        /// Unable to commit because a new key was added to the configuration file after last load operation. The newly added key is '{0}'.
        /// </summary>
        internal static string FormatError_CommitWhenNewKeyFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_CommitWhenNewKeyFound"), p0);
        }

        /// <summary>
        /// Keys in switch mappings are case-insensitive. A duplicated key '{0}' was found.
        /// </summary>
        internal static string Error_DuplicatedKeyInSwitchMappings
        {
            get { return GetString("Error_DuplicatedKeyInSwitchMappings"); }
        }

        /// <summary>
        /// Keys in switch mappings are case-insensitive. A duplicated key '{0}' was found.
        /// </summary>
        internal static string FormatError_DuplicatedKeyInSwitchMappings(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_DuplicatedKeyInSwitchMappings"), p0);
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is either abstract or an interface.
        /// </summary>
        internal static string Error_CannotActivateAbstractOrInterface
        {
            get { return GetString("Error_CannotActivateAbstractOrInterface"); }
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is either abstract or an interface.
        /// </summary>
        internal static string FormatError_CannotActivateAbstractOrInterface(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_CannotActivateAbstractOrInterface"), p0);
        }

        /// <summary>
        /// Failed to convert '{0}' to type '{1}'.
        /// </summary>
        internal static string Error_FailedBinding
        {
            get { return GetString("Error_FailedBinding"); }
        }

        /// <summary>
        /// Failed to convert '{0}' to type '{1}'.
        /// </summary>
        internal static string FormatError_FailedBinding(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FailedBinding"), p0, p1);
        }

        /// <summary>
        /// Failed to create instance of type '{0}'.
        /// </summary>
        internal static string Error_FailedToActivate
        {
            get { return GetString("Error_FailedToActivate"); }
        }

        /// <summary>
        /// Failed to create instance of type '{0}'.
        /// </summary>
        internal static string FormatError_FailedToActivate(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FailedToActivate"), p0);
        }

        /// <summary>
        /// The configuration file '{0}' was not found and is not optional.
        /// </summary>
        internal static string Error_FileNotFound
        {
            get { return GetString("Error_FileNotFound"); }
        }

        /// <summary>
        /// The configuration file '{0}' was not found and is not optional.
        /// </summary>
        internal static string FormatError_FileNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_FileNotFound"), p0);
        }

        /// <summary>
        /// File path must be a non-empty string.
        /// </summary>
        internal static string Error_InvalidFilePath
        {
            get { return GetString("Error_InvalidFilePath"); }
        }

        /// <summary>
        /// File path must be a non-empty string.
        /// </summary>
        internal static string FormatError_InvalidFilePath()
        {
            return GetString("Error_InvalidFilePath");
        }

        /// <summary>
        /// The switch mappings contain an invalid switch '{0}'.
        /// </summary>
        internal static string Error_InvalidSwitchMapping
        {
            get { return GetString("Error_InvalidSwitchMapping"); }
        }

        /// <summary>
        /// The switch mappings contain an invalid switch '{0}'.
        /// </summary>
        internal static string FormatError_InvalidSwitchMapping(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_InvalidSwitchMapping"), p0);
        }

        /// <summary>
        /// A duplicate key '{0}' was found.
        /// </summary>
        internal static string Error_KeyIsDuplicated
        {
            get { return GetString("Error_KeyIsDuplicated"); }
        }

        /// <summary>
        /// A duplicate key '{0}' was found.
        /// </summary>
        internal static string FormatError_KeyIsDuplicated(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_KeyIsDuplicated"), p0);
        }

        /// <summary>
        /// Unable to resolve path '{0}'; construct this {1} with a non-null {2}.
        /// </summary>
        internal static string Error_MissingBasePath
        {
            get { return GetString("Error_MissingBasePath"); }
        }

        /// <summary>
        /// Unable to resolve path '{0}'; construct this {1} with a non-null {2}.
        /// </summary>
        internal static string FormatError_MissingBasePath(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MissingBasePath"), p0, p1, p2);
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is missing a public parameterless constructor.
        /// </summary>
        internal static string Error_MissingParameterlessConstructor
        {
            get { return GetString("Error_MissingParameterlessConstructor"); }
        }

        /// <summary>
        /// Cannot create instance of type '{0}' because it is missing a public parameterless constructor.
        /// </summary>
        internal static string FormatError_MissingParameterlessConstructor(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MissingParameterlessConstructor"), p0);
        }

        /// <summary>
        /// No registered configuration source is capable of committing changes.
        /// </summary>
        internal static string Error_NoCommitableSource
        {
            get { return GetString("Error_NoCommitableSource"); }
        }

        /// <summary>
        /// No registered configuration source is capable of committing changes.
        /// </summary>
        internal static string FormatError_NoCommitableSource()
        {
            return GetString("Error_NoCommitableSource");
        }

        /// <summary>
        /// A configuration source is not registered. Please register one before setting a value.
        /// </summary>
        internal static string Error_NoSources
        {
            get { return GetString("Error_NoSources"); }
        }

        /// <summary>
        /// A configuration source is not registered. Please register one before setting a value.
        /// </summary>
        internal static string FormatError_NoSources()
        {
            return GetString("Error_NoSources");
        }

        /// <summary>
        /// The short switch '{0}' is not defined in the switch mappings.
        /// </summary>
        internal static string Error_ShortSwitchNotDefined
        {
            get { return GetString("Error_ShortSwitchNotDefined"); }
        }

        /// <summary>
        /// The short switch '{0}' is not defined in the switch mappings.
        /// </summary>
        internal static string FormatError_ShortSwitchNotDefined(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_ShortSwitchNotDefined"), p0);
        }

        /// <summary>
        /// Unrecognized argument format: '{0}'.
        /// </summary>
        internal static string Error_UnrecognizedArgumentFormat
        {
            get { return GetString("Error_UnrecognizedArgumentFormat"); }
        }

        /// <summary>
        /// Unrecognized argument format: '{0}'.
        /// </summary>
        internal static string FormatError_UnrecognizedArgumentFormat(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_UnrecognizedArgumentFormat"), p0);
        }

        /// <summary>
        /// Unrecognized line format: '{0}'.
        /// </summary>
        internal static string Error_UnrecognizedLineFormat
        {
            get { return GetString("Error_UnrecognizedLineFormat"); }
        }

        /// <summary>
        /// Unrecognized line format: '{0}'.
        /// </summary>
        internal static string FormatError_UnrecognizedLineFormat(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_UnrecognizedLineFormat"), p0);
        }

        /// <summary>
        /// Value for switch '{0}' is missing.
        /// </summary>
        internal static string Error_ValueIsMissing
        {
            get { return GetString("Error_ValueIsMissing"); }
        }

        /// <summary>
        /// Value for switch '{0}' is missing.
        /// </summary>
        internal static string FormatError_ValueIsMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_ValueIsMissing"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
