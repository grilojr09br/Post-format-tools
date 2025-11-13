using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WindowsSetup.App.Models;

namespace WindowsSetup.App.Views
{
    public partial class OptimizationWindow : Window
    {
        public OptimizationSettings Settings { get; private set; }
        public bool WasApplied { get; private set; }

        public OptimizationWindow()
        {
            InitializeComponent();
            Settings = new OptimizationSettings();
            WasApplied = false;
            
            // Update counter initially
            UpdateSelectedCount();
            
            // Add checkbox change handlers
            foreach (var checkbox in FindVisualChildren<CheckBox>(this))
            {
                checkbox.Checked += OnCheckboxChanged;
                checkbox.Unchecked += OnCheckboxChanged;
            }
        }

        private void OnCheckboxChanged(object sender, RoutedEventArgs e)
        {
            UpdateSelectedCount();
        }

        private void UpdateSelectedCount()
        {
            int count = FindVisualChildren<CheckBox>(this).Count(cb => cb.IsChecked == true);
            if (SelectedCountText != null)
            {
                SelectedCountText.Text = $"{count} optimizations selected";
            }
        }

        #region Preset Buttons

        private void Recommended_Click(object sender, RoutedEventArgs e)
        {
            // Performance (safe options)
            OptPowerPlan.IsChecked = true;
            OptMouseAcceleration.IsChecked = true;
            OptVisualEffects.IsChecked = true;
            OptExplorer.IsChecked = true;
            OptPageFile.IsChecked = false; // User preference
            OptBackgroundApps.IsChecked = true;
            OptTransparency.IsChecked = true;
            OptAnimations.IsChecked = false;
            OptStartup.IsChecked = false;

            // Privacy
            OptTelemetry.IsChecked = true;
            OptCortana.IsChecked = true;
            OptAdvertising.IsChecked = true;
            OptLocation.IsChecked = true;
            OptDiagnostics.IsChecked = true;
            OptActivityHistory.IsChecked = true;
            OptWebSearch.IsChecked = true;

            // Services (conservative)
            OptPrintSpooler.IsChecked = false;
            OptFaxService.IsChecked = false;
            OptWindowsSearch.IsChecked = false;
            OptSuperfetch.IsChecked = false;
            OptWindowsUpdate.IsChecked = false;

            // Gaming (moderate)
            OptGameMode.IsChecked = true;
            OptGameBar.IsChecked = false;
            OptGameDVR.IsChecked = true;
            OptHardwareAcceleratedGPU.IsChecked = true;
            OptFullscreenOptimizations.IsChecked = false;
            OptCPUScheduling.IsChecked = false;
            OptNagleAlgorithm.IsChecked = false;

            // Network (safe)
            OptTCPIP.IsChecked = false;
            OptDNS.IsChecked = true;
            OptNetworkThrottling.IsChecked = true;
            OptNetworkAdapter.IsChecked = false;
            OptLargeSendOffload.IsChecked = false;

            // Debloat
            OptCleanTempFiles.IsChecked = true;
            OptRemoveBloatware.IsChecked = false; // User decision
            OptDisableWidgets.IsChecked = true;
            OptRemoveCoPilot.IsChecked = false;
            OptDisableChat.IsChecked = true;
            OptEmptyRecycleBin.IsChecked = false;
            OptRemoveWindowsOld.IsChecked = false;

            // Storage
            OptSearchIndexing.IsChecked = false;
            OptSSD.IsChecked = true;
            OptSystemRestore.IsChecked = false;
            OptCompactOS.IsChecked = false;
            OptPrefetch.IsChecked = false;

            // CPU & Memory
            OptCoreParking.IsChecked = false;
            OptProcessorScheduling.IsChecked = true;
            OptMemoryManagement.IsChecked = true;
            OptWriteCache.IsChecked = false;
            OptSpectreMeltdown.IsChecked = false; // DANGEROUS

            // UI Tweaks
            OptShowFileExtensions.IsChecked = true;
            OptShowHiddenFiles.IsChecked = false;
            OptLockScreen.IsChecked = false;
            OptActionCenter.IsChecked = false;
            OptClassicContextMenu.IsChecked = false;
            OptTaskbarLeft.IsChecked = false;
            OptSnapAssist.IsChecked = false;

            // Advanced
            OptCreateRestorePoint.IsChecked = true; // IMPORTANT
            OptDisableOneDrive.IsChecked = false;
            OptDisableHibernation.IsChecked = false;
            OptFastStartup.IsChecked = false;
            OptRemoteAssistance.IsChecked = true;
            OptErrorReporting.IsChecked = true;

            UpdateSelectedCount();
        }

        private void Gaming_Click(object sender, RoutedEventArgs e)
        {
            // Performance (aggressive)
            OptPowerPlan.IsChecked = true;
            OptMouseAcceleration.IsChecked = true;
            OptVisualEffects.IsChecked = true;
            OptExplorer.IsChecked = true;
            OptPageFile.IsChecked = true;
            OptBackgroundApps.IsChecked = true;
            OptTransparency.IsChecked = true;
            OptAnimations.IsChecked = true;
            OptStartup.IsChecked = true;

            // Privacy
            OptTelemetry.IsChecked = true;
            OptCortana.IsChecked = true;
            OptAdvertising.IsChecked = true;
            OptLocation.IsChecked = true;
            OptDiagnostics.IsChecked = true;
            OptActivityHistory.IsChecked = true;
            OptWebSearch.IsChecked = true;

            // Services (disable non-essential)
            OptPrintSpooler.IsChecked = true;
            OptFaxService.IsChecked = true;
            OptWindowsSearch.IsChecked = true;
            OptSuperfetch.IsChecked = true;
            OptWindowsUpdate.IsChecked = false;

            // Gaming (ALL)
            OptGameMode.IsChecked = true;
            OptGameBar.IsChecked = true; // Some want it
            OptGameDVR.IsChecked = true;
            OptHardwareAcceleratedGPU.IsChecked = true;
            OptFullscreenOptimizations.IsChecked = true;
            OptCPUScheduling.IsChecked = true;
            OptNagleAlgorithm.IsChecked = true;

            // Network (gaming optimized)
            OptTCPIP.IsChecked = true;
            OptDNS.IsChecked = true;
            OptNetworkThrottling.IsChecked = true;
            OptNetworkAdapter.IsChecked = true;
            OptLargeSendOffload.IsChecked = true;

            // Debloat
            OptCleanTempFiles.IsChecked = true;
            OptRemoveBloatware.IsChecked = true;
            OptDisableWidgets.IsChecked = true;
            OptRemoveCoPilot.IsChecked = true;
            OptDisableChat.IsChecked = true;
            OptEmptyRecycleBin.IsChecked = false;
            OptRemoveWindowsOld.IsChecked = false;

            // Storage
            OptSearchIndexing.IsChecked = true;
            OptSSD.IsChecked = true;
            OptSystemRestore.IsChecked = false;
            OptCompactOS.IsChecked = false;
            OptPrefetch.IsChecked = true;

            // CPU & Memory (gaming)
            OptCoreParking.IsChecked = true;
            OptProcessorScheduling.IsChecked = true;
            OptMemoryManagement.IsChecked = true;
            OptWriteCache.IsChecked = true;
            OptSpectreMeltdown.IsChecked = false; // Still dangerous

            // UI Tweaks
            OptShowFileExtensions.IsChecked = true;
            OptShowHiddenFiles.IsChecked = true;
            OptLockScreen.IsChecked = true;
            OptActionCenter.IsChecked = true;
            OptClassicContextMenu.IsChecked = false;
            OptTaskbarLeft.IsChecked = false;
            OptSnapAssist.IsChecked = true;

            // Advanced
            OptCreateRestorePoint.IsChecked = true;
            OptDisableOneDrive.IsChecked = false;
            OptDisableHibernation.IsChecked = false;
            OptFastStartup.IsChecked = true;
            OptRemoteAssistance.IsChecked = true;
            OptErrorReporting.IsChecked = true;

            UpdateSelectedCount();
        }

        private void MaxPerformance_Click(object sender, RoutedEventArgs e)
        {
            // Select ALL performance options (EXPERT MODE)
            SelectAll_Click(sender, e);
            
            // Uncheck only the dangerous ones
            OptSpectreMeltdown.IsChecked = false; // Security risk
            OptSystemRestore.IsChecked = false; // Keep restore
            OptEmptyRecycleBin.IsChecked = false; // User data
            OptRemoveWindowsOld.IsChecked = false; // User data
            
            UpdateSelectedCount();
        }

        #endregion

        #region Select/Deselect

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            SetAllCheckboxes(true);
        }

        private void DeselectAll_Click(object sender, RoutedEventArgs e)
        {
            SetAllCheckboxes(false);
        }

        private void SetAllCheckboxes(bool value)
        {
            foreach (var checkbox in FindVisualChildren<CheckBox>(this))
            {
                checkbox.IsChecked = value;
            }
            UpdateSelectedCount();
        }

        #endregion

        #region Apply/Cancel

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            WasApplied = false;
            Close();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            // Collect settings from ALL checkboxes
            Settings = new OptimizationSettings
            {
                // Performance
                HighPerformancePowerPlan = OptPowerPlan.IsChecked ?? false,
                DisableMouseAcceleration = OptMouseAcceleration.IsChecked ?? false,
                OptimizeVisualEffects = OptVisualEffects.IsChecked ?? false,
                OptimizeExplorer = OptExplorer.IsChecked ?? false,
                DisableStartupPrograms = OptStartup.IsChecked ?? false,
                OptimizePageFile = OptPageFile.IsChecked ?? false,
                DisableBackgroundApps = OptBackgroundApps.IsChecked ?? false,
                DisableTransparency = OptTransparency.IsChecked ?? false,
                DisableAnimations = OptAnimations.IsChecked ?? false,

                // Privacy & Telemetry
                DisableTelemetry = OptTelemetry.IsChecked ?? false,
                DisableCortana = OptCortana.IsChecked ?? false,
                DisableAdvertisingId = OptAdvertising.IsChecked ?? false,
                DisableLocationTracking = OptLocation.IsChecked ?? false,
                DisableDiagnostics = OptDiagnostics.IsChecked ?? false,
                DisableActivityHistory = OptActivityHistory.IsChecked ?? false,
                DisableWebSearch = OptWebSearch.IsChecked ?? false,

                // Services
                DisablePrintSpooler = OptPrintSpooler.IsChecked ?? false,
                DisableFax = OptFaxService.IsChecked ?? false,
                DisableWindowsSearch = OptWindowsSearch.IsChecked ?? false,
                DisableSuperfetch = OptSuperfetch.IsChecked ?? false,
                SetWindowsUpdateManual = OptWindowsUpdate.IsChecked ?? false,

                // Gaming
                EnableGameMode = OptGameMode.IsChecked ?? false,
                DisableGameBar = OptGameBar.IsChecked ?? false,
                DisableGameDVR = OptGameDVR.IsChecked ?? false,
                EnableHardwareAcceleratedGPU = OptHardwareAcceleratedGPU.IsChecked ?? false,
                DisableFullscreenOptimizations = OptFullscreenOptimizations.IsChecked ?? false,
                OptimizeCPUScheduling = OptCPUScheduling.IsChecked ?? false,
                DisableNagleAlgorithm = OptNagleAlgorithm.IsChecked ?? false,

                // Network
                OptimizeTCPIP = OptTCPIP.IsChecked ?? false,
                OptimizeDNS = OptDNS.IsChecked ?? false,
                DisableNetworkThrottling = OptNetworkThrottling.IsChecked ?? false,

                // Debloat & Cleanup
                CleanTempFiles = OptCleanTempFiles.IsChecked ?? false,
                EmptyRecycleBin = OptEmptyRecycleBin.IsChecked ?? false,
                DeleteWindowsOld = OptRemoveWindowsOld.IsChecked ?? false,
                RemoveBloatwareApps = OptRemoveBloatware.IsChecked ?? false,
                DisableWidgets = OptDisableWidgets.IsChecked ?? false,
                RemoveCoPilot = OptRemoveCoPilot.IsChecked ?? false,

                // Storage & Memory
                DisableSearchIndexing = OptSearchIndexing.IsChecked ?? false,
                OptimizeSSD = OptSSD.IsChecked ?? false,

                // CPU & Memory
                DisableCoreParking = OptCoreParking.IsChecked ?? false,
                DisableSpectreMeltdown = OptSpectreMeltdown.IsChecked ?? false,
                OptimizeProcessorScheduling = OptProcessorScheduling.IsChecked ?? false,

                // UI Tweaks
                ShowFileExtensions = OptShowFileExtensions.IsChecked ?? false,
                DisableLockScreen = OptLockScreen.IsChecked ?? false,
                ClassicContextMenu = OptClassicContextMenu.IsChecked ?? false,

                // Advanced
                CreateRestorePoint = OptCreateRestorePoint.IsChecked ?? false,
                DisableOneDrive = OptDisableOneDrive.IsChecked ?? false,
                DisableHibernation = OptDisableHibernation.IsChecked ?? false,
                DisableFastStartup = OptFastStartup.IsChecked ?? false,
                DisableRemoteAssistance = OptRemoteAssistance.IsChecked ?? false,
                DisableErrorReporting = OptErrorReporting.IsChecked ?? false
            };

            WasApplied = true;
            Close();
        }

        #endregion

        #region Helper Methods

        private static System.Collections.Generic.IEnumerable<T> FindVisualChildren<T>(DependencyObject? depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject? child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T t)
                    {
                        yield return t;
                    }

                    if (child != null)
                    {
                        foreach (T childOfChild in FindVisualChildren<T>(child))
                        {
                            yield return childOfChild;
                        }
                    }
                }
            }
        }

        #endregion
    }
}
