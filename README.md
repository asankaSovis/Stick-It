# 📒 Stick It!

![Poster](https://user-images.githubusercontent.com/46389631/234660036-69f9ade7-2905-4c81-bb93-1bc842b9329a.png)

*💸 Please consider [donating](https://www.paypal.com/donate/?hosted_button_id=4EWXTWQ9FUFLA) on Paypal to keep this project alive.*

Stick It! is a basic note organizing app that can be used to store and pin notes to the screen. Simillar to the Microsoft Sticky notes, this can be used to write simple notes quickly and easily. Unlike Sticky Notes, this supports markdown and also has the functionality to pin the notes on top of other windows.

Stick It! is built with Microsoft Visual Studio 2019 using Visual C#. It uses the [Krypton Graphic elements](https://github.com/ComponentFactory/Krypton) for the interface. It uses the [MarkdownSharp](https://github.com/StackExchange/MarkdownSharp) library for parsing markdown data.

Stick It! is still in the alpha phase. This application is not ready as a daily driver for note taking. **It may have severe bugs and issues that may affect your work.** I'm still in the process of improving it and making it ready for general use.

> ![User Interface](https://user-images.githubusercontent.com/46389631/234654578-41de49df-2d75-4e4b-90f8-62b0be34b46d.png)
> User Interface

## 🧭 Features 
1. Supports adding, editing and deleting notes
2. Suports pinning notes to the top of the screen
3. Supports markdown formatting of text

## ✅ What's Next 
1. Refactor the code and clean some functions
2. Restructure the note file format to a proper format
3. Improve the look and feel of the interface with proper UI updates
4. Allow application to run in the background

## 🛠️ Technical Details 

### 1. Parsing Markdown
Markdown is parsed by first using Markdownsharp to convert it to HTML. This HTML is then displayed by the default windows web browser control (IE).

### 2. File Structure
A default folder (For now the location of the exe) exist. In it exist `assets` and `notes` folders. `assets` hold asset files of the application such as icons and images. `notes` folder contain each note. A note is a text file. The first line is the metadata line All lines after this are considered the note.
> NOTE: This structure will change

### 3. Metadata
For now, metadata only contain the note colour which is not used yet. More metadata will be used in the future along with colour support.
> NOTE: This structure will change

### 4. Identifying Notes
Each note is saved with its date and time as the filename. This is used to organize and differenciate each note. This is not efficient, so it will be changed.
> NOTE: This structure will change

### 5. Editing a Note
When application loads, it only loads the note metadata to conserve memory. When you view a note, the data is loaded. When editing, the edits are transfered to a cache which gets written to the file when saved.


## 📦 Releases

#### Version 1.0.0 Alpha [26/04/2023]

[Stick It! Version 1.0.0 Alpha](https://github.com/asankaSovis/Stick-It/releases/tag/v1.0.02)

> MD5: a0cd934a41272c559f371618fc99ad23
>
> SHA1: e4d4c29b53ad34a5e8c44f1a97a2ee28fceb1530
>
> SHA256: b55120a33d84300b721675687a3a16f014a06572d3cde6d1a188a535ed99f474

## 🛠️ Fixes and Features for the Next Release

- Suggest new features

`© 2023 Asanka Sovis`
