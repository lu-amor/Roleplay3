using NUnit.Framework;


namespace RoleplayGame
{
    public class RoleplayGameTests
    {
        /*
            JUSTIFICACIÓN:
            Este caso de prueba lo que revisa es si, al agregar un aspecto tan importante
            como el nombre de un personaje, es vacio o nulo.
            Si el llamado de la función devuelve TRUE, significa que el nombre pasó las validaciones correspondientes.
            Si devuelve FALSE, es sinonimo que el nombre no es valido para el personaje. 
        */
        [Test]
        public void TestBlankWizardName() {
            Wizard wiz = new Wizard("Alfredo");
            string newWizardName = "";

            bool result = wiz.SetName(newWizardName);
            Assert.False(result);
        }

        /*
            JUSTIFICACIÓN:
            Este test se encarga de realizar una prueba, de modo que no pueden haber 2 o 
            más hechizos con el mismo nombre, ya que si el nombre se repite 2 veces,
            el result2(último hechizo agregado) se considerará falso
        */
        [Test]
        public void TestDuplicatedSpell(){
            SpellsBook book = new SpellsBook();
            Spell sp = new Spell();

            bool result = book.AddSpell(sp);
            bool result2 = book.AddSpell(sp);
            Assert.False(result2);
        }
    }
}