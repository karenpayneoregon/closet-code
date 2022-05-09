using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLogForms1.Classes;
using NLogForms1.Interfaces;

namespace NLogForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Closing += OnClosing;

            // setup NLogging
            var (provider, logger) = Logging.Configuration();
            serviceProvider = provider;
            _logger = logger;

        }

        #region Logging configuration and private variables
        private readonly ServiceProvider serviceProvider;
        private readonly ILogger<Form1> _logger;
        #endregion

        private void ExecuteMethodButton_Click(object sender, EventArgs e)
        {
            var fooService = serviceProvider.GetService<ICommonService>();
            fooService.Execute();
        }

        private void WorkerMethodButton_Click(object sender, EventArgs e)
        {
            var fooService = serviceProvider.GetService<ICommonService>();
            fooService.Worker();
        }

        private void FinderButton_Click(object sender, EventArgs e)
        {
            var fileService = new FileServices(serviceProvider);
            fileService.FindFile();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _logger.LogInformation("Exiting application...");
        }
    }
}
