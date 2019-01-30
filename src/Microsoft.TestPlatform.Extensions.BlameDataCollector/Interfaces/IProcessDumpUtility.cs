﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.TestPlatform.Extensions.BlameDataCollector
{
    public interface IProcessDumpUtility
    {
        /// <summary>
        /// Get generated dump files
        /// </summary>
        /// <returns>
        /// Path of dump file
        /// </returns>
        string GetDumpFile();

        /// <summary>
        /// Launch procdump process
        /// </summary>
        /// <param name="processId">
        /// Process ID of test host
        /// </param>
        /// <param name="dumpFileGuid">
        /// Guid as postfix for dump file, testhost.exe_&lt;guid&gt;.dmp
        /// </param>
        /// <param name="testResultsDirectory">
        /// Path to TestResults directory
        /// </param>
        /// <param name="isFullDump">
        /// Is full dump enabled
        /// </param>
        void StartProcessDump(int processId, string dumpFileGuid, string testResultsDirectory, bool isFullDump = false);

        /// <summary>
        /// Terminate the proc dump process
        /// </summary>
        void TerminateProcess();
    }
}
