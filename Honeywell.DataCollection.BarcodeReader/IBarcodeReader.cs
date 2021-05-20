using System.Collections.Generic;
using System.Threading.Tasks;

namespace Honeywell.AIDC.CrossPlatform
{
    /// <summary>
    /// Provides common interface for a barcode reader. The <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReader" />
    /// class implements this interface.
    /// </summary>
    public interface IBarcodeReader
    {
        /// <summary>
        /// Gets a boolean value indicating whether the barcode reader is opened.
        /// </summary>
        bool IsReaderOpened { get; }

        /// <summary>Opens the barcode reader.</summary>
        /// <returns>A <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        Task<BarcodeReaderBase.Result> OpenAsync();

        /// <summary>Closes the barcode reader.</summary>
        /// <returns>A <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        Task<BarcodeReaderBase.Result> CloseAsync();

        /// <summary>Sets a collection of decoder or symbology settings.</summary>
        /// <param name="settings">A Dictionary object containing setting key-value pairs.</param>
        /// <returns>A <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>JJ
        Task<BarcodeReaderBase.Result> SetAsync(Dictionary<string, object> settings);

        /// <summary>
        /// Starts or stops the software trigger. When the on parameter is true, it
        /// activates the aimer to start decoding barcodes.
        /// Note: Some readers may not support the software trigger.
        /// </summary>
        /// <param name="on">A Boolean value to indicate whether to start or
        /// stop the software trigger.</param>
        /// <returns>A <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        Task<BarcodeReaderBase.Result> SoftwareTriggerAsync(bool on);

        /// <summary>Enables or disables the barcode reader.</summary>
        /// <param name="enabled">A Boolean value to indicate whether to enable or
        /// disable the barcode reader.</param>
        /// <returns>A <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        Task<BarcodeReaderBase.Result> EnableAsync(bool enabled);
    }
}