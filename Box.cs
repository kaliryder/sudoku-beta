public class Box
{
    /* array of 9 Cells */
    public Cell[] cells;
    /* array of ints 1-9 */
    int[] nums;
    /* Cells 1-9 */
    Cell c1;
    Cell c2;
    Cell c3;
    Cell c4;
    Cell c5;
    Cell c6;
    Cell c7;
    Cell c8;
    Cell c9;

    /* Ccnstructor takes 9 Cells as parameters */
    public Box(Cell c1, Cell c2, Cell c3, Cell c4, Cell c5, Cell c6, Cell c7, Cell c8, Cell c9) {
        /* assigns integers 1-9 to nums[] */
        nums = new int[9];
        for (int i = 0; i < 9; i++) {
            nums[i] = i+1;
        }
        /* assigns parameters to class Cell variables */
        this.c1 = c1;
        this.c2 = c2;
        this.c3 = c3;
        this.c4 = c4;
        this.c5 = c5;
        this.c6 = c6;
        this.c7 = c7;
        this.c8 = c8;
        this.c9 = c9;
        /* initialize cells[] */
        cells = new Cell[9];
        /* fills cells[] with Cell variables */
        cells[0] = this.c1;
        cells[1] = this.c2;
        cells[2] = this.c3;
        cells[3] = this.c4;
        cells[4] = this.c5;
        cells[5] = this.c6;
        cells[6] = this.c7;
        cells[7] = this.c8;
        cells[8] = this.c9;
    }

    public Cell[] getCells() {
        return cells;
    }
}