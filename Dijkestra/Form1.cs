using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MaxCut
{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //nodes = new ArrayList();
            nodes_hash = new Hashtable();
            edges = new ArrayList();
            //temp_list = new ArrayList();
            templist = new Hashtable();
        }

        Graphics gr;
       // ArrayList nodes,setted_node;
        ArrayList edges;
       // ArrayList set_A, set_B;
        //ArrayList perm_list, temp_list,saved_temp;
        int node_label = 1;
        Boolean is_to = false;
        Edge new_edge;
        Point p, q;
        Hashtable permlist, templist;
        Hashtable nodes_hash;
        Boolean dijkestra(string s,string t)
        {
            

            //if (temp_list.Count != nodes.Count)
            //{
            //    for (int i = 0; i < nodes.Count; i++)
            //    {
            //        ((node)nodes[i]).distance = Double.MaxValue;
            //    }
            //    temp_list = (ArrayList)nodes.Clone();
            //}

            if (templist.Count != nodes_hash.Count)
            {
                for (int i = 0; i < nodes_hash.Count; i++)
                {
                    ((node)nodes_hash[i+1]).distance = Double.MaxValue;
                }
                templist = (Hashtable)nodes_hash.Clone();
            } 

            //else
                //saved_temp = (ArrayList)temp_list.Clone();
            /////////////////////
            //perm_list = new ArrayList();
            permlist = new Hashtable();
            ///////// Initializing ////////
            int src=int.Parse(s) - 1;
            //((node)(temp_list[src])).distance = 0;
            //((node)(temp_list[src])).pred = "0";
            ((node)templist[int.Parse(s)]).distance = 0;
            ((node)templist[int.Parse(s)]).pred = "0";
           // perm_list.Add(temp_list[src]);
           // ok  permlist.Add(int.Parse(s), templist[int.Parse(s)]);
           // temp_list.RemoveAt(src);
           // ok  templist.Remove(int.Parse(s));
            //////////////////////////////
            //node designated_node = (node)perm_list[0];
            //node designate_node_hash = (node)permlist[int.Parse(s)];
            //for (int j = 0; j < edges.Count; j++)
            //{
            //    if (((Edge)edges[j]).from == designate_node_hash.name)
            //    {
            //        //int indx = get_idx_of(((Edge)edges[j]).to);

            //        //if (indx == -1) continue;
            //        //if (((node)temp_list[indx]).distance > designated_node.distance + ((Edge)edges[j]).wieght)
            //        //{
            //        //    ((node)temp_list[indx]).distance = designated_node.distance + ((Edge)edges[j]).wieght;
            //        //    ((node)temp_list[indx]).pred = designated_node.name;
            //        //}
            //        ///////////hash
            //        if (permlist[int.Parse(((Edge)edges[j]).to)] != null) continue;
            //        if (((node)templist[int.Parse(((Edge)edges[j]).to)]).distance > designate_node_hash.distance + ((Edge)edges[j]).wieght)
            //        {
            //            ((node)templist[int.Parse(((Edge)edges[j]).to)]).distance = designate_node_hash.distance + ((Edge)edges[j]).wieght;
            //            ((node)templist[int.Parse(((Edge)edges[j]).to)]).pred = designate_node_hash.name;
            //        }



            //        // sum += ((Edge)edges[j]).wieght;
            //    }
            //}


            Boolean path=true;
            /////////////////////////////////
            while(templist.Count>0 || path)
            {

                //designated_node=get_min_distance();
                node designate_node_hash = get_min_dist_hash();
               // perm_list.Add(temp_list[temp_list.IndexOf(designated_node)]);
                permlist.Add(int.Parse(((node)designate_node_hash).name), designate_node_hash);
               // temp_list.RemoveAt(temp_list.IndexOf(designated_node));
                templist.Remove(int.Parse(((node)designate_node_hash).name));

                for (int j = 0; j < edges.Count; j++)
                {
                    if (((Edge)edges[j]).from == designate_node_hash.name)
                    {
                       // int indx = get_idx_of(((Edge)edges[j]).to);
                       // if (indx == -1) continue;
                       //if (((node)temp_list[indx]).distance > designated_node.distance + ((Edge)edges[j]).wieght)
                       //{
                       //    ((node)temp_list[indx]).distance = designated_node.distance + ((Edge)edges[j]).wieght;
                       //    ((node)temp_list[indx]).pred = designated_node.name;
                       //}
                       ///////////hash
                        if(permlist[int.Parse(((Edge)edges[j]).to)]!=null)continue;
                       if (((node)templist[int.Parse(((Edge)edges[j]).to)]).distance > designate_node_hash.distance + ((Edge)edges[j]).wieght)
                       {
                           ((node)templist[int.Parse(((Edge)edges[j]).to)]).distance = designate_node_hash.distance + ((Edge)edges[j]).wieght;
                           ((node)templist[int.Parse(((Edge)edges[j]).to)]).pred = designate_node_hash.name;
                       }
                       // sum += ((Edge)edges[j]).wieght;
                    }
                }
                if (designate_node_hash.name == t)
                {
                    if (designate_node_hash.distance == Double.MaxValue)
                    { lbl_shortest_path.Text = ("No path exist between source and distination!"); return false; }
                    else
                    { lbl_shortest_path.Text= "Length Of Shortest Path : "+(designate_node_hash.distance.ToString()); return true; }
                    
                }

               


            }

            return false;




        }


        //int get_idx_of(string n)
        //{

        //    for (int i = 0; i < templist.Count; i++)
        //    {
        //        if (((node)temp_list[i]).name == n)
        //            return i;
        //    }

        //    return -1;
        //}

        node get_min_dist_hash()
        {
            IDictionaryEnumerator enumor = templist.GetEnumerator();
            node min_node=null;
           if(enumor.MoveNext())  min_node = (node)enumor.Value;
            
            while ((enumor.MoveNext()))
            {
                if (min_node.distance > ((node)enumor.Value).distance)
                    min_node = (node)enumor.Value;



            }


            return min_node;
        }


        //node get_min_distance()
        //{
        //    node min_node = (node)temp_list[0];
        //    for (int i = 0; i < temp_list.Count; i++)
        //    {
        //        if (min_node.distance > ((node)temp_list[i]).distance)
        //            min_node = (node)temp_list[i];
        //    }

        //    return min_node;

        //}


        void path_finder(string node_index)
        {
             // add found node to list
            lst_Path.Items.Add(node_index);
            if(((node)permlist[(int.Parse(node_index))]).pred!="0")
                path_finder(((node)permlist[(int.Parse(node_index))]).pred);


        }



        private void btn_max_cut_Click(object sender, EventArgs e)
        {
            if(cmb_dest.Text!="" && cmb_src.Text!="" && cmb_dest.Text!=cmb_src.Text)
            if (nodes_hash.Count>1)
            {
                //////////////red path if exist/////////////////////
                Pen mypen = new Pen(Color.Red, 4);
                System.Drawing.Drawing2D.AdjustableArrowCap bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 5);
                //int mxpq = (int)(p.X + q.X)/4;
                //int mypq = (int) (p.Y + q.Y)/4;
                //Point mpq = new Point(mxpq, mypq);
                for (int i = 0; i < lst_Path.Items.Count - 1; i++)
                {
                    for (int k = 0; k < edges.Count; k++)
                    {

                        if ((((Edge)edges[k]).from == lst_Path.Items[i + 1].ToString() && ((Edge)edges[k]).to == lst_Path.Items[i].ToString()))
                        {
                            int mxpq2 = (int)((((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_x + ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_x) / 2);
                            int mypq2 = (int)((((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_y + ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_y) / 2);
                            Point mpq2 = new Point(mxpq2, mypq2);
                            mypen.CustomEndCap = bigArrow;

                            gr.DrawLine(mypen, new Point(((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_x, ((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_y), mpq2);
                            // mypen.CustomEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            mypen.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;

                            gr.DrawLine(mypen, ((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_x, ((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_y, ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_x, ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_y);

                            // gr.DrawString("w: " + (((Edge)edges[k]).wieght).ToString(), new Font("Tahoma", 11), new SolidBrush(Color.Azure), Math.Abs(((node)set_A[i]).center_x + ((node)set_A[j]).center_x) / 2, Math.Abs(((node)set_A[i]).center_y + ((node)set_A[j]).center_y) / 2);
                        }
                    }
                }

                /////////////////////////////////
                lst_Path.Items.Clear();
                //lst_B.Items.Clear();

                if (dijkestra(cmb_src.Text, cmb_dest.Text))
                {
                    path_finder(cmb_dest.Text);
                }

/////////////////////////////////
                mypen = new Pen(Color.Gold, 4);
                bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 5);
                //int mxpq = (int)(p.X + q.X)/4;
                //int mypq = (int) (p.Y + q.Y)/4;
                //Point mpq = new Point(mxpq, mypq);
                
 


                //// make path gold
                for (int i = 0; i < lst_Path.Items.Count-1; i++)
                {
                    for (int k = 0; k < edges.Count; k++)
                    {
                        
                        if ((((Edge)edges[k]).from == lst_Path.Items[i + 1].ToString() && ((Edge)edges[k]).to == lst_Path.Items[i].ToString()))
                        {
                            int mxpq2 = (int)((((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_x + ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_x) / 2);
                            int mypq2 = (int)((((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_y + ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_y) / 2);
                            Point mpq2 = new Point(mxpq2, mypq2);
                            mypen.CustomEndCap = bigArrow;

                            gr.DrawLine(mypen, new Point(((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_x, ((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_y), mpq2);
                            // mypen.CustomEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            mypen.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;

                            gr.DrawLine(mypen, ((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_x, ((node)permlist[int.Parse(lst_Path.Items[i + 1].ToString())]).center_y, ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_x, ((node)permlist[int.Parse(lst_Path.Items[i].ToString())]).center_y);
                           
                            // gr.DrawString("w: " + (((Edge)edges[k]).wieght).ToString(), new Font("Tahoma", 11), new SolidBrush(Color.Azure), Math.Abs(((node)set_A[i]).center_x + ((node)set_A[j]).center_x) / 2, Math.Abs(((node)set_A[i]).center_y + ((node)set_A[j]).center_y) / 2);
                        }
                    }
                }


                //if (chk_boost.Checked)
                //{

                //    for (int i = 0; i < 80; i++)
                //    {

                //        setted_node = new ArrayList();
                //        try
                //        {
                //            set_A.Clear(); set_B.Clear(); setted_node.Clear();
                //        }
                //        catch
                //        {


                //        }
                //        int node_count = nodes.Count;
                //        /////////////////////// Randomiz
                //        take_random_permutation();
                //        ///////////////////////
                //        do_max_cut();
                //        float cw = get_cross_wieght();
                //        if (cw > max) max = cw;

                //    }

                //    // MessageBox.Show(max.ToString());
                //    //////////////////
                //    int jj = 0;
                //    while (get_cross_wieght() < max)
                //    {

                //        setted_node = new ArrayList();
                //        try
                //        {
                //            set_A.Clear(); set_B.Clear(); setted_node.Clear();
                //        }
                //        catch
                //        {


                //        }
                //        int node_count = nodes.Count;
                //        /////////////////////// Randomiz
                //        take_random_permutation();
                //        ///////////////////////
                //        do_max_cut();
                //        jj++;


                //    }
                //    //MessageBox.Show(jj.ToString());
                //}
                //else////////if no boost
                //{

                //    setted_node = new ArrayList();
                //    try
                //    {
                //        set_A.Clear(); set_B.Clear(); setted_node.Clear();
                //    }
                //    catch
                //    {


                //    }
                //    int node_count = nodes.Count;
                //    /////////////////////// Randomiz
                //    take_random_permutation();
                //    ///////////////////////
                //    do_max_cut();




                //}
               




                //////////////////
                //lbl_cross_weight.Text = "Sum of crossed edges weight : " + get_cross_wieght().ToString();
                //lbl_set_weight_a.Text = "Sum of Edges weight in A :" + get_set_wieght_A();
                //lbl_sum_weight_b.Text = "Sum of Edges weight in B :" + get_set_wieght_B();
                //for (int i = 0; i < set_A.Count; i++)
                //{
                //    lst_A.Items.Add(((node)set_A[i]).name);
                //    gr.FillEllipse(new SolidBrush(Color.Gold) /*Pen(Color.White, 3)*/, ((node)set_A[i]).center_x - 15, ((node)set_A[i]).center_y - 15, 30, 30);

                //}
                //for (int i = 0; i < set_B.Count; i++)
                //{
                //    lst_B.Items.Add(((node)set_B[i]).name);
                //    gr.FillEllipse(new SolidBrush(Color.Blue) /*Pen(Color.White, 3)*/, ((node)set_B[i]).center_x - 15, ((node)set_B[i]).center_y - 15, 30, 30);

                //}  
                //if (chk_replace.Checked) split();
            }
           
        }

        //public void split()
//        {
//           Point vl_point1 =new Point(pictureBox1.Width / 2,0);
//           Point vl_point2 = new Point(pictureBox1.Width /2, pictureBox1.Height - 1);
//           pictureBox1.Refresh();
//           gr.DrawLine(new Pen(Color.White, 4), vl_point1, vl_point2);
//           for (int i = 0; i < set_A.Count; i++)
//           {
               
//               if (((node)set_A[i]).center_x > vl_point1.X)
//                   ((node)set_A[i]).center_x = vl_point1.X - (((node)set_A[i]).center_x - vl_point1.X);
//               if ((-((node)set_A[i]).center_x+vl_point1.X) < 25) ((node)set_A[i]).center_x -= 25;
//               gr.FillEllipse(new SolidBrush(Color.Gold) /*Pen(Color.White, 3)*/, ((node)set_A[i]).center_x - 15, ((node)set_A[i]).center_y - 15, 30, 30);
//               gr.DrawString(((node)set_A[i]).name, new Font("Tahoma", 11), new SolidBrush(Color.Azure), ((node)set_A[i]).center_x + 15, ((node)set_A[i]).center_y + 15);

               
               
//           } 
///////////////////
//           for (int i = 0; i < set_B.Count; i++)
           //{
           //    if (((node)set_B[i]).center_x  < vl_point1.X)
           //        ((node)set_B[i]).center_x = vl_point1.X + (vl_point1.X - ((node)set_B[i]).center_x);
           //    if ((-vl_point1.X+ ((node)set_B[i]).center_x) < 25) ((node)set_B[i]).center_x += 25;   
           //    gr.FillEllipse(new SolidBrush(Color.Blue) /*Pen(Color.White, 3)*/, ((node)set_B[i]).center_x - 15, ((node)set_B[i]).center_y - 15, 30, 30);
           //    gr.DrawString(((node)set_B[i]).name, new Font("Tahoma", 11), new SolidBrush(Color.Azure), ((node)set_B[i]).center_x + 15, ((node)set_B[i]).center_y + 15);

               
           //}
           // ////////////// redraw edges
           //for (int i = 0; i < set_A.Count; i++)
           //{
           //    for (int j = 0; j < set_A.Count; j++)
           //    {
           //        for (int k = 0; k < edges.Count; k++)
           //        {
           //            if ((((Edge)edges[k]).from == ((node)set_A[i]).name && ((Edge)edges[k]).to == ((node)set_A[j]).name) || (((Edge)edges[k]).to == ((node)set_A[i]).name && ((Edge)edges[k]).from == ((node)set_A[j]).name))
           //            {
           //                gr.DrawLine(new Pen(Color.Red, 4), ((node)set_A[i]).center_x, ((node)set_A[i]).center_y, ((node)set_A[j]).center_x, ((node)set_A[j]).center_y);
           //                gr.DrawString("w: " + (((Edge)edges[k]).wieght).ToString(), new Font("Tahoma", 11), new SolidBrush(Color.Azure), Math.Abs(((node)set_A[i]).center_x + ((node)set_A[j]).center_x) / 2, Math.Abs(((node)set_A[i]).center_y + ((node)set_A[j]).center_y) / 2);
           //            }

           //        }
           //    }
           //} 
           // //////////////crossss
           //for (int i = 0; i < set_A.Count; i++)
           //{
           //    for (int j = 0; j < set_B.Count; j++)
           //    {
           //        for (int k = 0; k < edges.Count; k++)
           //        {
           //            if ((((Edge)edges[k]).from == ((node)set_A[i]).name && ((Edge)edges[k]).to == ((node)set_B[j]).name) || (((Edge)edges[k]).to == ((node)set_A[i]).name && ((Edge)edges[k]).from == ((node)set_B[j]).name))
           //            {
           //                gr.DrawLine(new Pen(Color.Green, 4), ((node)set_A[i]).center_x, ((node)set_A[i]).center_y, ((node)set_B[j]).center_x, ((node)set_B[j]).center_y);
           //                gr.DrawString("w: " + (((Edge)edges[k]).wieght).ToString(), new Font("Tahoma", 11), new SolidBrush(Color.Azure), Math.Abs(((node)set_A[i]).center_x + ((node)set_B[j]).center_x) / 2, Math.Abs(((node)set_A[i]).center_y + ((node)set_B[j]).center_y) / 2);

           //            }

           //        }
           //    }
           //}
           // //////////////////////B set Redraw
           //for (int i = 0; i < set_B.Count; i++)
           //{
           //    for (int j = 0; j < set_B.Count; j++)
           //    {
           //        for (int k = 0; k < edges.Count; k++)
           //        {
           //            if ((((Edge)edges[k]).from == ((node)set_B[i]).name && ((Edge)edges[k]).to == ((node)set_B[j]).name) || (((Edge)edges[k]).to == ((node)set_B[i]).name && ((Edge)edges[k]).from == ((node)set_B[j]).name))
           //            {
           //                gr.DrawLine(new Pen(Color.Red, 4), ((node)set_B[i]).center_x, ((node)set_B[i]).center_y, ((node)set_B[j]).center_x, ((node)set_B[j]).center_y);
           //                gr.DrawString("w: " + (((Edge)edges[k]).wieght).ToString(), new Font("Tahoma", 11), new SolidBrush(Color.Azure), Math.Abs(((node)set_B[i]).center_x + ((node)set_B[j]).center_x) / 2, Math.Abs(((node)set_B[i]).center_y + ((node)set_B[j]).center_y) / 2);

           //            }

           //        }
           //    }
           //}



            //////////////////////

        //}


        //public float get_inner_weight_sum(node n)
        //{
        //    float sum=0;
        //    if (n.set == "a")
        //    {
        //        for (int i = 0; i < set_A.Count; i++)
        //        {
        //            for (int j = 0; j < edges.Count; j++)
        //            {
            //            if ((((Edge)edges[j]).from == n.name && ((Edge)edges[j]).to == ((node)set_A[i]).name) || (((Edge)edges[j]).to == n.name && ((Edge)edges[j]).from == ((node)set_A[i]).name))
            //            sum += ((Edge)edges[j]).wieght;
            //        }
                    
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < set_B.Count; i++)
        //        {
        //            for (int j = 0; j < edges.Count; j++)
        //            {
        //                if ((((Edge)edges[j]).from == n.name && ((Edge)edges[j]).to == ((node)set_B[i]).name) || (((Edge)edges[j]).to == n.name && ((Edge)edges[j]).from == ((node)set_B[i]).name))
        //                    sum += ((Edge)edges[j]).wieght;
        //            }

        //        }



        //    }

        //    return sum;
            
        //}



        //public float get_outer_weight_sum(node n)
        //{
        //    float sum = 0;
        //    if (n.set == "b")
        //    {
        //        for (int i = 0; i < set_A.Count; i++)
        //        {
        //            for (int j = 0; j < edges.Count; j++)
        //            {
        //                if ((((Edge)edges[j]).from == n.name && ((Edge)edges[j]).to == ((node)set_A[i]).name) || (((Edge)edges[j]).to == n.name && ((Edge)edges[j]).from == ((node)set_A[i]).name))
        //                    sum += ((Edge)edges[j]).wieght;
        //            }

        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < set_B.Count; i++)
        //        {
        //            for (int j = 0; j < edges.Count; j++)
        //            {
        //                if ((((Edge)edges[j]).from == n.name && ((Edge)edges[j]).to == ((node)set_B[i]).name) || (((Edge)edges[j]).to == n.name && ((Edge)edges[j]).from == ((node)set_B[i]).name))
        //                    sum += ((Edge)edges[j]).wieght;
        //            }

        //        }



        //    }

        //    return sum;

            
        //}




 


        //public void do_max_cut()
        //{

        //    for (int i = 0; i < setted_node.Count; i++)
        //    {
        //        if (get_inner_weight_sum(((node)setted_node[i])) > get_outer_weight_sum(((node)setted_node[i])))
        //        {
        //            if (((node)setted_node[i]).set == "a")
        //            {
        //                ((node)setted_node[i]).set = "b";
        //                set_B.Add(set_A[set_A.IndexOf(((node)setted_node[i]))]);
        //                set_A.RemoveAt(set_A.IndexOf(((node)setted_node[i])));
        //            }
        //            else
        //            {
        //                ((node)setted_node[i]).set = "a";

        //                set_A.Add(set_B[set_B.IndexOf(((node)setted_node[i]))]);
        //                set_B.RemoveAt(set_B.IndexOf(((node)setted_node[i])));
                        
            //        }
            //     //  if (checkBox1.Checked) 
            //        i = 0;
            //    }

            //}


           // MessageBox.Show(get_cross_wieght().ToString());


        //}


        //public float get_cross_wieght()
        //{
        //    float sum = 0;
        //    for (int i = 0; i < set_A.Count; i++)
        //    {
        //        for (int j = 0; j < set_B.Count; j++)
        //        {
        //            for (int k = 0; k < edges.Count; k++)
        //            {
        //                if ((((Edge)edges[k]).from == ((node)set_A[i]).name && ((Edge)edges[k]).to == ((node)set_B[j]).name) || (((Edge)edges[k]).to == ((node)set_A[i]).name && ((Edge)edges[k]).from == ((node)set_B[j]).name))
        //                sum += ((Edge)edges[k]).wieght;
        //            }
        //        }
        //    }

        //    return sum;
        //}


        //public float get_set_wieght_A()
        //{
        //    float sum = 0;
        //    for (int i = 0; i < set_A.Count; i++)
        //    {
        //        for (int j = 0; j < set_A.Count; j++)
        //        {
        //            for (int k = 0; k < edges.Count; k++)
        //            {
        //                if ((((Edge)edges[k]).from == ((node)set_A[i]).name && ((Edge)edges[k]).to == ((node)set_A[j]).name) || (((Edge)edges[k]).to == ((node)set_A[i]).name && ((Edge)edges[k]).from == ((node)set_A[j]).name))
        //                    sum += ((Edge)edges[k]).wieght;
        //            }
        //        }
        //    }

        //    return sum/2;
        //}


        //public float get_set_wieght_B()
        //{
        //    float sum = 0;
        //    for (int i = 0; i < set_B.Count; i++)
        //    {
        //        for (int j = 0; j < set_B.Count; j++)
        //        {
        //            for (int k = 0; k < edges.Count; k++)
        //            {
        //                if ((((Edge)edges[k]).from == ((node)set_B[i]).name && ((Edge)edges[k]).to == ((node)set_B[j]).name) || (((Edge)edges[k]).to == ((node)set_B[i]).name && ((Edge)edges[k]).from == ((node)set_B[j]).name))
        //                    sum += ((Edge)edges[k]).wieght;
        //            }
        //        }
        //    }

        //    return sum / 2;
        //}



        //public void take_random_permutation()
        //{
        //    for (int i = 0; i < nodes.Count; i++)
        //        ((node)nodes[i]).set = "b";
            
        //    ArrayList temp =(ArrayList) nodes.Clone();
        //    set_A = new ArrayList();
        //    Random rnd = new Random();
        //    for (int i = 0; i <= temp.Count/2; i++)
        //    {
        //        int node_index = rnd.Next(0, temp.Count - 1);
        //        ((node)temp[node_index]).set = "a";
        //        setted_node.Add(((node)temp[node_index]));
        //        set_A.Add(temp[node_index]);
        //        temp.RemoveAt(node_index);

        //    }
        //    set_B = (ArrayList) temp.Clone();
        //    setted_node.AddRange(set_B);


        //}

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //nodes = new ArrayList();
            resete();
        }

        void resete()
        {

            nodes_hash = new Hashtable();
            edges = new ArrayList();
            //temp_list = new ArrayList();
            templist = new Hashtable();
            cmb_src.Items.Clear();
            cmb_dest.Items.Clear();
            //setted_node = new ArrayList();
            lst_Path.Items.Clear();
            lst_B.Items.Clear();
            pictureBox1.Refresh();
            node_label = 1;


        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Random rnd = new Random();
                int r = RandNumber(100, 255); int g = RandNumber(60, 255); int b = RandNumber(80, 255);
                gr.FillEllipse(new SolidBrush(Color.FromArgb(r, g, b)) /*Pen(Color.White, 3)*/, e.X - 15, e.Y - 15, 30, 30);
             //   nodes.Add(new node((node_label).ToString(), e.X, e.Y));
                nodes_hash.Add(node_label, new node((node_label).ToString(), e.X, e.Y));
             //   temp_list.Add(new node((node_label).ToString(), e.X, e.Y));
                templist.Add(node_label, new node((node_label).ToString(), e.X, e.Y));
                cmb_src.Items.Add(node_label);
                cmb_dest.Items.Add(node_label);
                gr.DrawString((node_label++).ToString() , new Font("Tahoma", 11), new SolidBrush(Color.Azure), e.X + 15, e.Y + 15);
            }
            else
            {
                // (x-center_x)^2 + (y - center_y)^2 < radius^2
                for (int i = 0; i < nodes_hash.Count; i++)
                {
                    if ((Math.Abs((e.X - ((node)nodes_hash[i+1]).center_x)) <= 15) && (Math.Abs(e.Y - ((node)nodes_hash[i+1]).center_y)) <= 15)
                    {
                        if (!is_to)
                        {
                            new_edge = new Edge();
                            new_edge.from = ((node)nodes_hash[i + 1]).name;
                            p.X = ((node)nodes_hash[i + 1]).center_x;
                            p.Y = ((node)nodes_hash[i + 1]).center_y;
                        }
                        else
                        {
                            new_edge.to = ((node)nodes_hash[i + 1]).name;
                            q.X = ((node)nodes_hash[i + 1]).center_x;
                            q.Y = ((node)nodes_hash[i + 1]).center_y;
                            try
                            {
                                new_edge.wieght = float.Parse(Prompt.ShowDialog("Enter Distance of Arc :", "Distance"));

                            }
                            catch
                            {
                                new_edge.wieght = 10;
                                
                            }
                            Pen mypen=new Pen(Color.Red, 4);
                            System.Drawing.Drawing2D.AdjustableArrowCap bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(5,5);
                            //int mxpq = (int)(p.X + q.X)/4;
                            //int mypq = (int) (p.Y + q.Y)/4;
                            //Point mpq = new Point(mxpq, mypq);
                            int mxpq2 = (int)((p.X + q.X) / 2);
                            int mypq2 = (int)((p.Y + q.Y) / 2);
                            Point mpq2 = new Point(mxpq2, mypq2);

                            mypen.CustomEndCap = bigArrow;
                            gr.DrawLine(mypen, p, mpq2);
                           // mypen.CustomEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            mypen.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                            gr.DrawLine(mypen, p, q);
                            edges.Add(new_edge);
                            gr.DrawString((new_edge.wieght).ToString(), new Font("Tahoma", 12), new SolidBrush(Color.Azure), Math.Abs(p.X + q.X) / 2, Math.Abs(p.Y + q.Y) / 2);
                            //gr.g(">" , new Font("Tahoma", 13), new SolidBrush(Color.Red), (int)(Math.Abs(p.X + q.X) / 1.5), (int)(Math.Abs(p.Y + q.Y) / 1.5));
                            
                        }
                        is_to = !is_to;
                        break;
                    }
                }
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = Graphics.FromHwnd(pictureBox1.Handle);
            Form1.CheckForIllegalCrossThreadCalls = false;
           
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Maximum Cut Problem     " + " X=" + e.X.ToString() + "  Y=" + e.Y.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           // pictureBox1.Refresh();
        }






        public static int RandNumber(int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(Low, High);

            return rnd;
        }


        Boolean is_close(int x,int y)
        {
           IDictionaryEnumerator enu= nodes_hash.GetEnumerator();
           while (enu.MoveNext())
           {
               if (Math.Abs(((node)enu.Value).center_x - x) <= 30) return true;
               if (Math.Abs(((node)enu.Value).center_y - y) <= 30) return true;
           }
           return false;
        }


        private void btn_random_Click(object sender, EventArgs e)
        {
            resete();
            for (int i = 0; i < 7; )
            {


                int r = RandNumber(100, 255); int g = RandNumber(60, 255); int b = RandNumber(80, 255);
                int x = RandNumber(26, pictureBox1.Width - 26);
                int y = RandNumber(26, pictureBox1.Height - 26);
                if(!is_close(x,y))
                {
                    i++;
                    gr.FillEllipse(new SolidBrush(Color.FromArgb(r, g, b)) /*Pen(Color.White, 3)*/, x - 15, y - 15, 30, 30);
                //   nodes.Add(new node((node_label).ToString(), e.X, e.Y));
                    nodes_hash.Add(node_label, new node((node_label).ToString(), x, y));
                //   temp_list.Add(new node((node_label).ToString(), e.X, e.Y));
                    templist.Add(node_label, new node((node_label).ToString(), x, y));
                    cmb_src.Items.Add(node_label);
                    cmb_dest.Items.Add(node_label);
                    gr.DrawString((node_label++).ToString(), new Font("Tahoma", 11), new SolidBrush(Color.Azure), x + 15, y + 15);
                }
            }
            ///////////////// arc
            int from= RandNumber(1, nodes_hash.Count);
            new_edge = new Edge();
            new_edge.from = ((node)nodes_hash[i + 1]).name;
            p.X = ((node)nodes_hash[i + 1]).center_x;
            p.Y = ((node)nodes_hash[i + 1]).center_y;







            ///////////////////////////
        }



    }
}
