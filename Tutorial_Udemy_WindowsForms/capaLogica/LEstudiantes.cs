using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaData;
using capaLogica.Library;
using CapaLogica.Library;
using LinqToDB;
using Tutorial_Udemy_WindowsForms;


namespace capaLogica
{
    public class LEstudiantes : Librarys
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        public PictureBox image;
        private Bitmap imageBitMap;
        private DataGridView dataGridView;
        private NumericUpDown numericUpDown;
        private Paginador<Estudiante> _paginador;
        private string _accion = "Insert";
        //private Librarys Librarys; gracias a la herencia ya no es necesario
        public LEstudiantes(List<TextBox> TextBox, List<Label> listLabel, Object[] objetos) 
        {
            this.listTextBox = TextBox;
            this.listLabel = listLabel;
            this.image = (PictureBox)objetos[0];
            this.imageBitMap = (Bitmap)objetos[1];
            this.dataGridView = (DataGridView)objetos[2];
            this.numericUpDown = (NumericUpDown)objetos[3];
            Limpiar();
            //Librarys = new Librarys();
        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "Campo requerido";
                listLabel[0].ForeColor = Color.Red;
                listLabel[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "Campo requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listLabel[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "Campo requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listLabel[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "Campo requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listLabel[3].Focus();
                        }
                        else
                        {
                            if (txtBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                            {
                                var user = SqlEstudiantes.Where(e => e.Email == listTextBox[3].Text).ToList();
                                if (user.Count.Equals(0))
                                {
                                    Guardar();
                                }
                                else
                                {
                                    if (user[0].ID.Equals(_idEstudiante))
                                    {
                                        _accion = "Update";
                                        Guardar();
                                    }
                                    else
                                    {
                                        listLabel[3].Text = "El Email ya existe";
                                        listLabel[3].ForeColor = Color.Red;
                                        listLabel[3].Focus();
                                    } 
                                }
                            }
                            else
                            {
                                listLabel[3].Text = "Email no valido";
                                listLabel[3].ForeColor = Color.Red;
                                listLabel[3].Focus();
                            }
                        }
                    }
                }
            }
            //int i = 0;
            //while (i < listTextBox.Count)
            //{
            //    if (listTextBox[i].Text.Equals(""))
            //    {
            //        listLabel[i].Text = "Campo requerido";
            //        listLabel[i].ForeColor = Color.Red;
            //        listLabel[i].Focus();
            //    }   
            //    i++;
            //}
        }   
        public void BuscarEstudiante(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();
            int inicio = (num_pagina - 1) * reg_por_pagina;
            if (campo.Equals(""))
            {
                query = SqlEstudiantes.ToList();
            }
            else
            {
                query = SqlEstudiantes.Where(e => e.NID.StartsWith(campo) ||
                                            e.Nombre.StartsWith(campo) ||
                                            e.Apellido.StartsWith(campo)).ToList();
            }
            if (query.Count > 0)
            {
                dataGridView.DataSource = query.Select(c => new
                {
                    c.ID,
                    c.NID,
                    c.Nombre,
                    c.Apellido,
                    c.Email,
                    c.Image
                }).Skip(inicio).Take(reg_por_pagina).ToList();
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[5].Visible = false;

                dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.GhostWhite;
                dataGridView.Columns[2].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            else
            {
                dataGridView.DataSource = query.Select(c => new
                {
                    c.ID,
                    c.NID,
                    c.Nombre,
                    c.Apellido,
                    c.Email
                });
            }
        }
        public void paginador(string boton)
        {
            switch (boton)
            {
                case "Primero":
                    _paginador.Primero();
                    break;
                case "Anterior":
                    _paginador.Anterior();
                    break;
                case "Siguiente":
                    _paginador.Sigueinte();
                    break;
                case "Ultimo":
                    _paginador.Ultimo();
                    break;
            }
        }
        public void Guardar()
        {
            var arrayImage = uploadImage.ImageToByte(image.Image);
            //using (var db = new Coneccion())
            //{
            //    db.Insert(new Estudiante()
            //    {
            //        NID = listTextBox[0].Text,
            //        Nombre = listTextBox[1].Text,
            //        Apellido = listTextBox[2].Text,
            //        Email = listTextBox[3].Text,
            //    });
            //}
            BeginTransactionAsync(); //Incerta los datos de otra forma, que puede ser util aveces
            try
            {
                var ArrayImage = uploadImage.ImageToByte(image.Image);
                switch (_accion)
                {
                    case "Insert":
                        SqlEstudiantes.Value(e => e.NID, listTextBox[1].Text)
                          .Value(e => e.Nombre, listTextBox[0].Text)
                          .Value(e => e.Apellido, listTextBox[2].Text)
                          .Value(e => e.Email, listTextBox[3].Text) 
                          .Value(e => e.Image, ArrayImage)
                          .Insert();
                        break;
                    case "Update":
                        SqlEstudiantes.Where(u => u.ID.Equals(_idEstudiante))
                           .Set(e => e.NID, listTextBox[1].Text)
                           .Set(e => e.Nombre, listTextBox[0].Text)
                           .Set(e => e.Apellido, listTextBox[2].Text)
                           .Set(e => e.Email, listTextBox[3].Text)
                           .Set(e => e.Image, ArrayImage)
                           .Update();
                        break;
                }
                
                CommitTransaction(); // Le dice al BTA que puede incertar los datos
                Limpiar();
            }
            catch (Exception ex)
            {
                RollbackTransaction(); // Detiene el metodo BTA, para que no se incentren los datos
            }
        }

        private List<Estudiante> listEstudiante;
        private int _idEstudiante = 0;
        public void GetEstudiante()
        {
            _accion = "update";
            _idEstudiante = Convert.ToInt16(dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[1].Text = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[0].Text = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(dataGridView.CurrentRow.Cells[4].Value);
            try
            {
                image.Image = uploadImage.byteArrayToImage((byte[])dataGridView.CurrentRow.Cells[5].Value); //no me funciona, ya funciona :)
            }catch (Exception e)
            {
                image.Image = imageBitMap;
            }

        }
        public void registroPaginas()
        {
            num_pagina = 1;
            reg_por_pagina = (int)numericUpDown.Value;
            var list = SqlEstudiantes.ToList();
            if( 0 < list.Count)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], reg_por_pagina);
                BuscarEstudiante("");
            }
        }
        private int reg_por_pagina = 2; private int num_pagina = 1;

        public void Limpiar()
        {
            _accion = "Insert";
            image.Image = imageBitMap;
            listLabel[0].Text = "Nombre";
            listLabel[0].Text = "ID";
            listLabel[0].Text = "Apellido";
            listLabel[0].Text = "Email";
            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].ForeColor = Color.LightSlateGray;
            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listEstudiante = SqlEstudiantes.ToList();
            if (listEstudiante.Count > 0)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], reg_por_pagina);
            }
            BuscarEstudiante("");
        }
        public void Eliminar()
        {
            if (_idEstudiante.Equals(0))
            {
                MessageBox.Show("Seleccione un estudiante");
            }
            else
            {
                if (MessageBox.Show("Seguro de eliminar este estudiante?", "Eliminar estudiante",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlEstudiantes.Where(e => e.ID.Equals(_idEstudiante)).Delete();
                    Limpiar();
                }
            }
        }
    }
}
