# 📒 Stick-It
Stick It is a basic note organizing app that can be used to store and pin notes to the screen. Simillar to the Microsoft Sticky notes, this can be used to write simple notes quickly and easily. Unlike Sticky Notes, this supports markdown and also has the functionality to pin the notes on top of other windows.

Stick-It is built with Microsoft Visual Studio 2019 using Visual C#. It uses the [Krypton Graphic elements](https://github.com/ComponentFactory/Krypton) for the interface. It uses the [MarkdownSharp](https://github.com/StackExchange/MarkdownSharp) library for parsing markdown data and [NewtonsoftJSON](https://www.newtonsoft.com/json) to serialize and deserialize JSON.

Stick-It is still in the alpha phase. This application is not ready as a daily driver for note taking. **It may have severe bugs and issues that may affect your work.** I'm still in the process of improving it and making it ready for general use.

`v0.1.1 Screenshots`
![image](https://user-images.githubusercontent.com/46389631/165118730-90b373c5-8ef3-4744-880e-3cd90beb0d6b.png)

## 1. Features ✏️
1. Supports adding, editing and deleting notes
2. Suports pinning notes to the top of the screen
3. Supports markdown formatting of text

## 2. What's Next ✅
1. Refactor the code and clean some functions
2. Restructure the note file format to a proper format
3. Improve the look and feel of the interface with proper UI updates
4. Allow application to run in the background
5. Make a proper logo
6. Add an about page

## 3. Technical Details 🛠️

### 3.1. Parsing Markdown
Markdown is parsed by first using Markdownsharp to convert it to HTML. This HTML is then displayed by the default windows web browser control (IE).

### 3.2. File Structure
A default folder (For now the location of the exe) exist. In it exist `assets` and `notes` folders. `assets` hold asset files of the application such as icons and images. `notes` folder contain each note. A note is a text file. The first line is the metadata line All lines after this are considered the note.
> NOTE: This structure will change

### 3.3. Metadata
For now, metadata only contain the note colour which is not used yet. More metadata will be used in the future along with colour support.
> NOTE: This structure will change

### 3.4. Identifying Notes
Each note is saved with its date and time as the filename. This is used to organize and differenciate each note. This is not efficient, so it will be changed.
> NOTE: This structure will change

### 3.5. Editing a Note
When application loads, it only loads the note metadata to conserve memory. When you view a note, the data is loaded. When editing, the edits are transfered to a cache which gets written to the file when saved.

[#PrayForSriLanka 🇱🇰](https://twitter.com/search?q=%23PrayForSriLanka&src=typeahead_click)

`© 2022 Asanka Sovis`
