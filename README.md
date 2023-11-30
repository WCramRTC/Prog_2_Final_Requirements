# Prog_2_FinalReview

![Completed Application](Images/Complete.gif)

You will be creating your own application that utilizes all the controls you been learning, and then utilizing lists and creating classes.

You will also get an extra credit opportunity: Create your own classes related to your interest and add the needed functionality to work with.

---

# Programming Final Rubric

# Programming Final Rubric

Total Points: 300

| **Task**                                  | **Points** | **Description**                                                                                      |
|-------------------------------------------|------------|-------------------------------------------------------------------------------------------------------|
| ***Section 1: Basic Requirements***         |            |                                                                                                       |
| **Name on Application**                     | 20         | Student must include their name in a clearly visible part of the application.                         |
| **Code Commenting**                        | 30         | Code must be well-commented, explaining the functionality and logic.                                  |
| **Build and Run**                           | 50         | Application must build and run properly without errors upon submission.                               |
| ***Section 2: Using Correct Controls***   |            |                                                                                                       |
| **Display Information**                     |            |                                                                                                       |
|   - ListView                              | 15         | Implement ListView with a Selection Changed Event to display formatted information in RichTextBox.    |
|   - RichTextBox                           | 10         | Correctly implement a RichTextBox to display information.                                             |
| **Choose or Add a Category**                |            |                                                                                                       |
|   - ComboBox                              | 15         | Implement ComboBox with Selected Index Change Event to display category information in ListView.      |
|   - Label, TextBox, Button                | 15         | Correct use of Label, TextBox, and Button for adding a category.                                      |
| **Add Information To Category**             |            |                                                                                                       |
|   - Label: Add Item                       | 5          | Implement a label to indicate the function to add an item.                                            |
|   - TextBox: To Add Item                  | 5          | Use a TextBox for inputting an item to add.                                                           |
|   - Label: Add Description                | 5          | Implement a label to indicate where to add a description.                                             |
|   - RichTextBox: To write a description   | 10         | Use a RichTextBox for writing a detailed description.                                                 |
|   - Checkbox: High Priority               | 5          | Include a checkbox to mark an item as high priority.                                                  |
|   - Checkbox: Time Sensitive              | 5          | Include a checkbox to mark an item as time sensitive.                                                 |
|   - Button: To Add Item to Selected Category | 5      | Implement a button to add the item to the selected category.                                          |
| **Update Information**                      |            |                                                                                                       |
|   - Button: To update selected item       | 10         | Implement a Button to update selected items.                                                          |
| **Clear Boxes**                             |            |                                                                                                       |
|   - Button: Clears boxes and resets buttons | 10      | Implement a Button that clears text boxes, rich text boxes, check boxes, and resets radio buttons.    |
| **Is Completed**                            |            |                                                                                                       |
|   - Radio Button: Is Completed            | 5          | Implement and correctly function a 'Is Completed' radio button.                                       |
|   - Radio Button: Not Completed           | 5          | Implement and correctly function a 'Not Completed' radio button.                                      |
| **Section 3: Class Construction**         |            |                                                                                                       |
| - Class Design                            | 30         | Classes must be properly designed and relevant to the application's functionality.                    |
| - Class Implementation                    | 40         | Proper implementation of classes including methods, properties, and constructors.                     |
| - Class Integration                       | 30         | Classes must be integrated correctly and work seamlessly within the application.                      |

---


## Knowledge Need

All Controls
    - Give names to reference in your C# code
    - Add events
    - Change Text ( replace and append )
    - Get values

- TextBox
- Label
- Button
- Rich Text Box ( Run specifically )
    - Give run a name
    - How to append text
    - How to replace text
- ListBox and ComboBox
    - Items Source
    - Selected Index
    - On Selection Change event
- Lists
    - Create and initialize in local and global scope
    - Add files
    - Access individual elements
- Classes
    - Create classes in their own files
    - Fields
    - Constructors
    - Properties
    - Methods
    - Object in objects
    - How to override to strings
    - Checking for null
- CheckBox and RadioButton
    - How to get and respond to the selected value
- ListView
    - Items Source
        - Change source on load, and while application is running
    - Selected Index
        - Check if item is selected ( index != -1 )
    - On Selection Change Event

---
## Layout

![Layout](Images/Layout.png)

- Category change box
    - Combobox to hold category names
        - Has an on selection changed event
        - Displays todo items for category in listview
- Add New Category
    - Label, TextBox, Button
- Display ToDo Items
    - ListView
        - Has a selection changed event
        - Selected item information displays on rich text box to the right and text box info below.
- Task Name
    - Label, Textbox
- Description Box
    - Label
    - Rich Text Box
- High Importance
    - Check Box
- Time Sensitive
    - Check Box
- Complete and Not Completes
    - Radio Buttons, grouped together
- Add To List
    - Button
    - Event that adds new item to current category
- Update Selected Item
    - Button
    - Updates the currently selected item with the new information
- Clear Boxes
    - Clears all check boxes, text boxes, rich text boxes, sets the list view selection to -1, and sets radio button to not completed.
- Display Information
    - Rich Text Box

---

## Classes

### ***Item.cs***
The item class represents a single "To Do" list item.

- **Fields and Properties ( Gets and Sets for all )**

```csharp
    string _name;
    string _description;
    bool _highImportance;
    bool _timeSensitive;
    bool _isCompleted;
```

- **Constructor**
    - Takes arguments for 
        - Name
        - Description
        - High Importance
        - Time Sensitive
    - Sets `_isCompleted` to false

- **Methods**
    - `string DisplayInformation()`
        - Returns a string with the instanced Items information.

        Ex.
![Description](Images/Description.png)

    - `void AssignmentCompleted()`
        - Assigns true to the `isCompleted` property
        - Appends "**Task Completed**" to the description

        Ex. ![Description](Images/Assignment_Completed.gif)

---

### ***Category.cs***
Category represent a unique category item with it's own list of "To Do" items associated with it.

- **Fields and Properties ( getters and setters for both)**

```csharp
    string _name;
    List<Item> _todoItemsInCategory;
```

- **Constructor**
    - Create a constructor that takes a name
    - Initialize the List<Item> in your constructor

- **Methods**
    - `void AddItemToCategory(Item item)`
        - Pass an item in to add it to our category to do list
        - This replaces have the user have to do use `categoryName.TodoItemsInCategory.Add()`. It helps read ability and *abstracts* how our code works ( more on this in programming 3 ).
    - `override string ToString()`
        - Return the category name
        - This is used to easily display the category name to our combo box.

--- 

## MainWindow.xaml.cs

### Create two global variables

```csharp
    List<Category> _categories;
    Category selectedCategory;
```

- Initialize the list in MainWindow()
- Assign categories to your combo boxes ItemsSource
- Set the selected index of your combo box to 0. The ensures the first item will be selected.

### - **Add Task ( Button Click Event )**
- When clicked, creates a new Item instance and assigns it to the currently selected category
- Validation: Requires name and description. If either are **Empty**, display a messagebox saying "Please enter name and description".
- Refresh the listview. `listViewName.Items.Refresh();`

![Add Task Example](Images/Add_Task.gif)

### - **Update Task ( Button Click Event )**

- When clicked, the item selected in the list view is updated with the information located below.
- If the Completed radio button is selected, the selected Items `assignmentCompleted()` method should be called.
- Refresh the listview. `listViewName.Items.Refresh();`

![Add Task Example](Images/Update_Task.gif)

### - **Clear Input Boxes ( Button Click Event )**

- When clicked, all information is cleared from the boxes.
    - The task textbox, description, and full display are set to "".
    - The check boxes are set to false
    - The radio button, Not Completed, is selected
    - !! The selected index of the list view is set to -1.
        > Setting the selected index to -1 deselects everything from the list view.

![Add Task Example](Images/Clear.gif)

### - **Add Category ( Button Click Event )**

- When clicked, adds a new category to our category list.
- The Combo box should refresh to show the next category.
    - `comboBoxName.Items.Refresh();`

![Add Task Example](Images/AddCategory.gif)

### - **Preload**
Call this in your MainWindow(). This will populate your categories list with 3 categories, and 1 item in each category a piece. Feel free to change and add information as you like.

```csharp
    _categories = new List<Category>
    {
        new Category("Today"),
        new Category("Shopping"),
        new Category("Travel")
    };

    // Adding items to our Today category
    int index = 0;
    _categories[index].AddItemToCategory(new Item("Grocery Shopping", "Go to Fred Meyers", false, true));

    // Adding items to our Shopping category
    index = 1;
    _categories[index].AddItemToCategory(new Item("Pick up Cat Food", "Get Cuts", true, true));

    // Adding items to our Travel category
    index = 2;
    _categories[index].AddItemToCategory(new Item("TPick up travel adapter", "Make sure it covers the UK", true, true));
```

### - **Select Item in ListView ( Selection Changed Event )**

- When an item is clicked in the list view, the `DisplayInformation()` method is called and the resultant string is assigned to the RTB Display Information.
- The task TextBox, description RTB, two check boxes and the radio button are all updated with information from the selected item.

![Add Task Example](Images/SelectItem.gif)

### - **Change Category ( Selection Changed Event )**
- When a new category is seleceted, the items in it's `_todoItemsInCategory` are displayed in the list view.
- This can be done by assigning the categories name to the list view .ItemsSource


![Add Task Example](Images/ChangeCategory.gif)