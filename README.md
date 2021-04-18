# About EdvFramework
Have a different style!

<p align="center">
  <img src="logo_description.png" alt="Logo" width="300px"/>
</p>

EdvFramework is a framework created by Edivaldo Jorge, with the aim of changing the standardized style of Windows forms

#How to use
1. Add a new reference to your project and choose the EdvFramework.dll file.
2. Create a new form and give it a name.
3. Double-click on the form to view in code mode.

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    //Code example Normal Windows form without using the EdvFramework.EdvForm class
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
```

4. Change the parent class of the form to EdvFramework.EdvForm and then go to designer mode and watch the magic happen.
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    //Sample code for a form using the EdvFramework.EdvForm class
    public partial class Form1 : EdvFramework.EdvForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
```

5. Now that your project already has the EdvFramework style, just use it.
