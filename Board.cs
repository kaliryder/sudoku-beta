public class Board
{
    /* column a Cell variables */
    public Cell a1;
    public Cell a2;
    public Cell a3;
    public Cell a4;
    public Cell a5;
    public Cell a6;
    public Cell a7;
    public Cell a8;
    public Cell a9;
    /* column b Cell variables */
    public Cell b1;
    public Cell b2;
    public Cell b3;
    public Cell b4;
    public Cell b5;
    public Cell b6;
    public Cell b7;
    public Cell b8;
    public Cell b9;
    /* column c Cell variables */
    public Cell c1;
    public Cell c2;
    public Cell c3;
    public Cell c4;
    public Cell c5;
    public Cell c6;
    public Cell c7;
    public Cell c8;
    public Cell c9;
    /* column d Cell variables */
    public Cell d1;
    public Cell d2;
    public Cell d3;
    public Cell d4;
    public Cell d5;
    public Cell d6;
    public Cell d7;
    public Cell d8;
    public Cell d9;
    /* column e Cell variables */
    public Cell e1;
    public Cell e2;
    public Cell e3;
    public Cell e4;
    public Cell e5;
    public Cell e6;
    public Cell e7;
    public Cell e8;
    public Cell e9;
    /* column f Cell variables */
    public Cell f1;
    public Cell f2;
    public Cell f3;
    public Cell f4;
    public Cell f5;
    public Cell f6;
    public Cell f7;
    public Cell f8;
    public Cell f9;
    /* column g Cell variables */
    public Cell g1;
    public Cell g2;
    public Cell g3;
    public Cell g4;
    public Cell g5;
    public Cell g6;
    public Cell g7;
    public Cell g8;
    public Cell g9;
    /* column h Cell variables */
    public Cell h1;
    public Cell h2;
    public Cell h3;
    public Cell h4;
    public Cell h5;
    public Cell h6;
    public Cell h7;
    public Cell h8;
    public Cell h9;
    /* column i Cell variables */
    public Cell i1;
    public Cell i2;
    public Cell i3;
    public Cell i4;
    public Cell i5;
    public Cell i6;
    public Cell i7;
    public Cell i8;
    public Cell i9;
    /* Box variables */
    Box box1;
    Box box2;
    Box box3;
    Box box4;
    Box box5;
    Box box6;
    Box box7;
    Box box8;
    Box box9;

    public Board(string nums) {
        /*
        /* initializing a column variables
        a1 = new Cell(int.Parse(nums[0].ToString()), false);
        a2 = new Cell(int.Parse(nums[1].ToString()), false);
        a3 = new Cell(int.Parse(nums[2].ToString()), false);
        a4 = new Cell(int.Parse(nums[3].ToString()), true);
        a5 = new Cell(int.Parse(nums[4].ToString()), false);
        a6 = new Cell(int.Parse(nums[5].ToString()), true);
        a7 = new Cell(int.Parse(nums[6].ToString()), false);
        a8 = new Cell(int.Parse(nums[7].ToString()), false);
        a9 = new Cell(int.Parse(nums[8].ToString()), true);
        /* initializing b column variables
        b1 = new Cell(int.Parse(nums[9].ToString()), true);
        b2 = new Cell(int.Parse(nums[10].ToString()), false);
        b3 = new Cell(int.Parse(nums[11].ToString()), false);
        b4 = new Cell(int.Parse(nums[12].ToString()), false);
        b5 = new Cell(int.Parse(nums[13].ToString()), true);
        b6 = new Cell(int.Parse(nums[14].ToString()), true);
        b7 = new Cell(int.Parse(nums[15].ToString()), true);
        b8 = new Cell(int.Parse(nums[16].ToString()), true);
        b9 = new Cell(int.Parse(nums[17].ToString()), true);
        /* initializing c column variables
        c1 = new Cell(int.Parse(nums[18].ToString()), true);
        c2 = new Cell(int.Parse(nums[19].ToString()), false);
        c3 = new Cell(int.Parse(nums[20].ToString()), false);
        c4 = new Cell(int.Parse(nums[21].ToString()), true);
        c5 = new Cell(int.Parse(nums[22].ToString()), false);
        c6 = new Cell(int.Parse(nums[23].ToString()), false);
        c7 = new Cell(int.Parse(nums[24].ToString()), true);
        c8 = new Cell(int.Parse(nums[25].ToString()), true);
        c9 = new Cell(int.Parse(nums[26].ToString()), true);
        /* initializing d column variables
        d1 = new Cell(int.Parse(nums[27].ToString()), true);
        d2 = new Cell(int.Parse(nums[28].ToString()), false);
        d3 = new Cell(int.Parse(nums[29].ToString()), false);
        d4 = new Cell(int.Parse(nums[30].ToString()), false);
        d5 = new Cell(int.Parse(nums[31].ToString()), false);
        d6 = new Cell(int.Parse(nums[32].ToString()), false);
        d7 = new Cell(int.Parse(nums[33].ToString()), false);
        d8 = new Cell(int.Parse(nums[34].ToString()), false);
        d9 = new Cell(int.Parse(nums[35].ToString()), true);
        /* initializing e column variables
        e1 = new Cell(int.Parse(nums[36].ToString()), true);
        e2 = new Cell(int.Parse(nums[37].ToString()), true);
        e3 = new Cell(int.Parse(nums[38].ToString()), true);
        e4 = new Cell(int.Parse(nums[39].ToString()), false);
        e5 = new Cell(int.Parse(nums[40].ToString()), true);
        e6 = new Cell(int.Parse(nums[41].ToString()), false);
        e7 = new Cell(int.Parse(nums[42].ToString()), true);
        e8 = new Cell(int.Parse(nums[43].ToString()), false);
        e9 = new Cell(int.Parse(nums[44].ToString()), false);
        /* initializing f column variables
        f1 = new Cell(int.Parse(nums[45].ToString()), false);
        f2 = new Cell(int.Parse(nums[46].ToString()), false);
        f3 = new Cell(int.Parse(nums[47].ToString()), false);
        f4 = new Cell(int.Parse(nums[48].ToString()), false);
        f5 = new Cell(int.Parse(nums[49].ToString()), false);
        f6 = new Cell(int.Parse(nums[50].ToString()), true);
        f7 = new Cell(int.Parse(nums[51].ToString()), true);
        f8 = new Cell(int.Parse(nums[52].ToString()), false);
        f9 = new Cell(int.Parse(nums[53].ToString()), true);
        /* initializing g column variables
        g1 = new Cell(int.Parse(nums[54].ToString()), true);
        g2 = new Cell(int.Parse(nums[55].ToString()), true);
        g3 = new Cell(int.Parse(nums[56].ToString()), true);
        g4 = new Cell(int.Parse(nums[57].ToString()), true);
        g5 = new Cell(int.Parse(nums[58].ToString()), true);
        g6 = new Cell(int.Parse(nums[59].ToString()), false);
        g7 = new Cell(int.Parse(nums[60].ToString()), true);
        g8 = new Cell(int.Parse(nums[61].ToString()), false);
        g9 = new Cell(int.Parse(nums[62].ToString()), false);
        /* initializing h column variables
        h1 = new Cell(int.Parse(nums[63].ToString()), true);
        h2 = new Cell(int.Parse(nums[64].ToString()), true);
        h3 = new Cell(int.Parse(nums[65].ToString()), false);
        h4 = new Cell(int.Parse(nums[66].ToString()), false);
        h5 = new Cell(int.Parse(nums[67].ToString()), true);
        h6 = new Cell(int.Parse(nums[68].ToString()), true);
        h7 = new Cell(int.Parse(nums[69].ToString()), false);
        h8 = new Cell(int.Parse(nums[70].ToString()), true);
        h9 = new Cell(int.Parse(nums[71].ToString()), false);
        /* initializing i column variables
        i1 = new Cell(int.Parse(nums[72].ToString()), false);
        i2 = new Cell(int.Parse(nums[73].ToString()), true);
        i3 = new Cell(int.Parse(nums[74].ToString()), false);
        i4 = new Cell(int.Parse(nums[75].ToString()), false);
        i5 = new Cell(int.Parse(nums[76].ToString()), true);
        i6 = new Cell(int.Parse(nums[77].ToString()), false);
        i7 = new Cell(int.Parse(nums[78].ToString()), true);
        i8 = new Cell(int.Parse(nums[79].ToString()), false);
        i9 = new Cell(int.Parse(nums[80].ToString()), false);
        */
        /* initializing Box variables
        box1 = new Box(a1, b1, c1, a2, b2, c2, a3, b3, c3);
        box2 = new Box(d1, e1, f1, d2, e2, f2, d3, e3, f3);
        box3 = new Box(g1, h1, i1, g2, h2, i2, g3, h3, i3);
        box4 = new Box(a4, b4, c4, a5, b5, c5, a6, b6, c6);
        box5 = new Box(d4, e4, f4, d5, e5, f5, d6, e6, f6);
        box6 = new Box(g4, h4, i4, g5, h5, i5, g6, h6, i6);
        box7 = new Box(a7, b7, c7, a8, b8, c8, a9, b9, c9);
        box8 = new Box(d7, e7, f7, d8, e8, f8, d9, e9, f9);
        box9 = new Box(g7, h7, i7, g8, h8, i8, g9, h9, i9);
        */
    }
}
