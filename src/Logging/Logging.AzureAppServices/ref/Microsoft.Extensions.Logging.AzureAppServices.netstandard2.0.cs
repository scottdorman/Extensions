// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Extensions.Logging
{
    public static partial class AzureAppServicesLoggerFactoryExtensions
    {
        public static Microsoft.Extensions.Logging.ILoggingBuilder AddAzureWebAppDiagnostics(this Microsoft.Extensions.Logging.ILoggingBuilder builder) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging.AzureAppServices
{
    public partial class AzureBlobLoggerOptions : Microsoft.Extensions.Logging.AzureAppServices.BatchingLoggerOptions
    {
        public AzureBlobLoggerOptions() { }
        public string BlobName { get { throw null; } set { } }
    }
    public partial class AzureFileLoggerOptions : Microsoft.Extensions.Logging.AzureAppServices.BatchingLoggerOptions
    {
        public AzureFileLoggerOptions() { }
        public string FileName { get { throw null; } set { } }
        public System.Nullable<int> FileSizeLimit { get { throw null; } set { } }
        public System.Nullable<int> RetainedFileCountLimit { get { throw null; } set { } }
    }
    public partial class BatchingLoggerOptions
    {
        public BatchingLoggerOptions() { }
        public System.Nullable<int> BackgroundQueueSize { get { throw null; } set { } }
        public System.Nullable<int> BatchSize { get { throw null; } set { } }
        public System.TimeSpan FlushPeriod { get { throw null; } set { } }
        public bool IncludeScopes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public abstract partial class BatchingLoggerProvider : Microsoft.Extensions.Logging.ILoggerProvider, Microsoft.Extensions.Logging.ISupportExternalScope, System.IDisposable
    {
        internal BatchingLoggerProvider() { }
        public bool IsEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName) { throw null; }
        public void Dispose() { }
        protected virtual System.Threading.Tasks.Task IntervalAsync(System.TimeSpan interval, System.Threading.CancellationToken cancellationToken) { throw null; }
        void Microsoft.Extensions.Logging.ISupportExternalScope.SetScopeProvider(Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider) { }
    }
    [Microsoft.Extensions.Logging.ProviderAliasAttribute("AzureAppServicesBlob")]
    public partial class BlobLoggerProvider : Microsoft.Extensions.Logging.AzureAppServices.BatchingLoggerProvider
    {
        public BlobLoggerProvider(Microsoft.Extensions.Options.IOptionsMonitor<Microsoft.Extensions.Logging.AzureAppServices.AzureBlobLoggerOptions> options) { }
    }
    [Microsoft.Extensions.Logging.ProviderAliasAttribute("AzureAppServicesFile")]
    public partial class FileLoggerProvider : Microsoft.Extensions.Logging.AzureAppServices.BatchingLoggerProvider
    {
        public FileLoggerProvider(Microsoft.Extensions.Options.IOptionsMonitor<Microsoft.Extensions.Logging.AzureAppServices.AzureFileLoggerOptions> options) { }
    }
}
