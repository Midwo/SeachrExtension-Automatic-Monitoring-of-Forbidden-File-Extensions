# SeachrExtension - Automatic Monitoring of Forbidden File Extensions
A lightweight Windows Forms tool for automatically monitoring user directories (local or shared profiles) for forbidden file extensions. When matching files are detected, the 
application sends an email notification to all configured recipients.
## 1. Overview

The program scans a selected root directory (including all subfolders) for specific file extensions. Monitoring can run at a fixed time or at regular intervals. When files 
matching the configured extensions are found, an automatic email report is sent using the sender account defined in the application.

## 2. Features
  * Automatic extension scanning — monitors a chosen directory and its full internal structure.
  * Scheduled or interval-based execution — run at a specific time or every X minutes.
  * Email notifications — sends reports to all configured recipients.
  * Editable configuration — add/edit paths, email recipients, and file extensions.
  * Mixed storage approach — registry for email settings, file-based storage for recipient list, EF6 + LocalDb for extension database.

## 3. Tech Stack
  *	C#
  *	Windows Forms
  *	EF6 + LocalDb
  *	Windows Registry
      
## 4. Screenshots: 
**1. Main View**
<br>
Directory preview, extension list, schedule settings, and current monitoring status.

<img src="https://github.com/Midwo/SeachrExtension-Automatic-Monitoring-of-Forbidden-File-Extensions/blob/master/SearchExtension/SearchExtension1.png" width="700" alt="Main Application Window">

**2. Registry Configuration**
<br>
Email account settings stored in Windows Registry.

<img src="https://github.com/Midwo/SeachrExtension-Automatic-Monitoring-of-Forbidden-File-Extensions/blob/master/SearchExtension/SearchExtension2.png" width="700" alt="Registry Configuration">

**3. Example Report Email**

<img src="https://github.com/Midwo/SeachrExtension-Automatic-Monitoring-of-Forbidden-File-Extensions/blob/master/SearchExtension/SearchExtension3.png" width="700" alt="Report Email">

**4. Recipient Management**
<br>
Add, edit, or remove email recipients.
  
<img src="https://github.com/Midwo/SeachrExtension-Automatic-Monitoring-of-Forbidden-File-Extensions/blob/master/SearchExtension/SearchExtension4.png" width="700" alt="Inport data">
<img src="https://github.com/Midwo/SeachrExtension-Automatic-Monitoring-of-Forbidden-File-Extensions/blob/master/SearchExtension/SearchExtension5.png" width="700" alt="Inport data">

