namespace _01Objektumok
{
    public class Plane
    {
        public Plane()
        {
        }

        //Állapot
        //mező (field)
        //kívülről is látható
        //tartalmazza az élek számát
        public int NrOfEdge;

        //hasonlít a belső osztályszintű változókhoz
        private int NrOfNodes;

        //tulajdonság (property)
        //ugyanazt tudja, mint a mező, ha az alapértelmezett (default) implementációt használjuk

        public int NrOfArcs { get; set; }

        //azonban a fordító egy ilyen kóddá alakítja(külön vaálasztjuk a tulajdonság írását és olvasását):

        //backing field, ez tartalmazza a property értékét
        private int _nrOfArcs;
        //getter fgv.
        public int NrOfArcs_GET()
        {
            return _nrOfArcs;
        }
        //setter fgv., beállítja a property értékét
        public void NrOfArcs_SET(int value)
        {
            _nrOfArcs = value;
        }
        //következmények
        //1. Mivel elválasztottuk az írást és az olvasást, külön tudunk dönteni róluk
        //csak olvasható property
        public int Data1 { get; } //default alak
        //csak írható property, ebben az esetben implementálnom kell, mert  a bejövő adathoz nme férek másképp hozzá
        //definíció szerint a bejövő paraméter neve "value", típusa mindig a property típusa  
        private int _data2;
        public int Data2 { set { _data2 = value; } } //nem default alak, mert tartalmaz implementációt
        //2. külön tudom a láthatóságot szabályozni
        //olvasni csak az osztályon belülről, írni osztályon kívülről is lehet
        public int Data3 {private get; set; }
        //olvasni mindenhonnan, írni csak osztályon belülről
        public int Data4 { get; private set; }

        //3. a fordító a default alakban egy default implementációt készít a kódunkból
        //default alak implementáció nélküli, csak get/set szerepel a definícióban

        //4. Mi van, ha szeretném implementálni a getter vagy a setter fgv-t?

        //valószínüleg kell egy backing field 
        private string _name;
        public string Name
        {
            get
            {
                //tetszőleges művelet
                //majd a property típusának megfelelő érték visszaadása
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //Viselkedés: függvényeken keresztül lehet szabályozni
        //függvény overloading
        public void Show()
        {

        }

        //nem a név, hanem a szignatura (név + paraméterek típusa) azonosítja a függvényt, így
        //ugyanolyan névvel tudunk több fgv-t létrehozni,ha a szignaturájuk különbözik

        public void Show(bool disabled)
        {

        }

        public void Show(int posX, int posY)
        {

        }

        //stb., stb., stb.
        // a visszatérési érték sem a szignatura része, így ez sem működik

        //public void Show()
        //{
        //    return 0;
        //}

        //A függvények paraméterei a következők lehetnek alapértelmezésben:
        //ha a paraméter típusa értéktípusként viselkedik, akkor az paraméterátadás is érték szerint történik
        //ha a paraméter típusa referenciatípusként viselkedik, akkor az paraméterátadás is referencia szerint történik
        //ezt felül tudjuk írni, ha érték típust akarunk referencia szerint átadni, akkor ref kulcsszót használjuk
        //out paraméternél mindenképp kell értéket adnunk az out-ként definiált paraméternek
        public void Show(int height, ReferenciaTipus referencia, ref int width, out int ertek3)
        {
            System.Console.WriteLine($"Show height: {height}, referencia: {referencia.ertek}, width: {width}");
            height = height * 2;
            referencia.ertek = referencia.ertek*2;
            width *= 2;
            ertek3 = 10;
            System.Console.WriteLine($"Show height: {height}, referencia: {referencia.ertek}, width: {width}");
        }

        //A fgv paramétereinek lehet alaértelmezett értéket adni:

        public void Show(int height=5, int width=10, string name="név")
        {

        }

    }
}