using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Virtual_Mente.Models;

namespace Virtual_Mente.Controllers
{
    public class ShowTextImageController : Controller
    {
        String text;
        int index;
        int idPregunta;
  


   
        public ActionResult Structure()
        {
            return View();
        }
        public ActionResult Test(String titulo = "")
        {
            ViewBag.Titulo = titulo;
            ViewBag.TipoJuego = mostrarCuento(titulo);
            return View();
        }

            public string mostrarCuento(String titulo)
        {
            string cuento = "";
            string cuento1 = "En la granja había un gran alboroto: los polluelos de Mamá Pata estaban rompiendo el cascarón. Uno a uno, comenzaron a salir.Mamá Pata estaba tan emocionada con sus adorables patitos que no notó que uno de sus huevos, el más grande de todos, permanecía intacto. A las pocas horas, el último huevo comenzó a romperse. Mamá Pata, todos los polluelos y los animales de la granja, se encontraban a la expectativa de conocer al pequeño que tardaba en nacer.De repente, del cascarón salió un patito muy alegre.Cuando todos lo vieron se quedaron sorprendidos, este patito no era pequeño ni amarillo y tampoco estaba cubierto de suaves plumas. Este patito era grande, gris y en vez del esperado graznido, cada vez que hablaba sonaba como una corneta vieja. Aunque nadie dijo nada, todos pensaron lo mismo: Este patito es demasiado feo. Pasaron los días y todos los animales de la granja se burlaban de él. El patito feo se sintió muy triste y una noche escapó de la granja para buscar un nuevo hogar. El patito feo recorrió la profundidad del bosque y cuando estaba a punto de darse por vencido, encontró el hogar de una humilde anciana que vivía con una gata y una gallina.El patito se quedó con ellos durante un tiempo, pero como no estaba contento, pronto se fue. Al llegar el invierno, el pobre patito feo casi se congela.Afortunadamente, un campesino lo llevó a su casa a vivir con su esposa e hijos. Pero el patito estaba aterrado de los niños, quienes gritaban y brincaban todo el tiempo y nuevamente escapó, pasando el invierno en un estanque pantanoso. Finalmente, llegó la primavera.El patito feo vio a una familia de cisnes nadando en el estanque y quiso acercarse. Pero recordó cómo todos se burlaban de él y agachó la cabeza avergonzado.Cuando miró su reflejo en el agua se quedó asombrado. Él no era un patito feo, sino un apuesto y joven cisne. Ahora sabía por qué se veía tan diferente a sus hermanos y hermanas. ¡Ellos eran patitos, pero él era un cisne! Feliz, nadó hacia su familia. ";
            string cuento2 = "En una vieja carpintería, Geppetto, un señor amable y simpático, terminaba un día más de trabajo dando los últimos retoques de pintura a un muñeco de madera que había construido. Al mirarlo, pensó: '¡Qué bonito me ha quedado!'.Y como el muñeco había sido hecho de madera de pino, Geppetto decidió llamarlo Pinocho.Aquella noche, Geppetto se fue a dormir, deseando que su muñeco fuese un niño de verdad. Siempre había deseado tener un hijo. Y al encontrarse profundamente dormido, llegó un hada buena y viendo a Pinocho tan bonito, quiso premiar al buen carpintero, dando, con su varita mágica, vida al muñeco. Al día siguiente, cuando se despertó, Geppetto no podía creerlo: Pinocho se movía, caminaba, se reía y hablaba como un niño de verdad para alegría del viejo carpintero. Feliz y muy satisfecho, Geppetto mandó a Pinocho a la escuela. Quería que fuese un niño muy listo y que aprendiera muchas cosas. Le acompañó su amigo Pepito Grillo, el consejero que le había dado el hada buena. Pero, en el camino del colegio, Pinocho se hizo amigo de dos niños muy malos, siguiendo sus travesuras, e ignorando los consejos del grillito. En lugar de ir a la escuela, Pinocho decidió seguir a sus nuevos amigos, buscando aventuras no muy buenas. Al ver esta situación, el hada buena le hechizó. Por no ir a la escuela, le colocó dos orejas de burro, y por portarse mal, le dijo que cada vez que dijera una mentira, le crecería la nariz, poniéndose además colorada. Pinocho acabó reconociendo que no estaba siendo bueno, y arrepentido, decidió buscar a Geppetto. Supo entonces que Geppetto, al salir en su busca por el mar, había sido tragado por una enorme ballena.Pinocho, con la ayuda del grillito, se fue a la mar para rescatar al pobre viejecito. Cuando Pinocho estuvo frente a la ballena le pidió que le devolviese a su papá, pero la ballena abrió su enorme boca y se lo tragó también a él. Dentro de la tripa de la ballena, Geppetto y Pinocho se reencontraron.Y se pusieron a pensar cómo salir de allí. Y gracias a Pepito Grillo encontraron una salida. Hicieron una fogata.El fuego hizo estornudar a la enorme ballena, y la balsa salió volando con sus tres tripulantes. Todos se salvaron.Pinocho volvió a casa y al colegio, y a partir de ese día siempre se comportó bien. Y en recompensa de su bondad, el hada buena lo convirtió en un niño de carne y hueso, y fueron muy felices por muchos y muchos años.";
            string cuento3 = "En el mundo de los animales vivía una liebre muy orgullosa y vanidosa, que solo decía que ella era el animal más veloz del bosque, y que se pasaba el día burlándose de la lentitud de la tortuga. - ¡Eh, tortuga, no corras tanto! Decía la liebre riéndose de la tortuga. Un día, a la tortuga se le ocurrió hacerle una inusual apuesta a la liebre: -Liebre, ¿vamos a hacer una carrera? Estoy segura de poder ganarte. - ¿A mí? Preguntó asombrada la liebre. -Sí, sí, a ti, dijo la tortuga. Pongamos nuestras apuestas y veamos quién gana la carrera. La liebre, muy engreída, aceptó la apuesta prontamente. Así que todos los animales se reunieron para presenciar la carrera.El búho ha sido el responsable de señalizar los puntos de partida y de llegada.Y así empezó la carrera: Astuta y muy confiada en sí misma, la liebre salió corriendo, y la tortuga se quedó atrás, tosiendo y envuelta en una nube de polvo. Cuando empezó a andar, la liebre ya se había perdido de vista.Sin importarle la ventaja que tenía la liebre sobre ella, la tortuga seguía su ritmo, sin parar. La liebre, mientras tanto, confiando en que la tortuga tardaría mucho en alcanzarla, se detuvo a la mitad del camino ante un frondoso y verde árbol, y se puso a descansar antes de terminar la carrera. Allí se quedó dormida, mientras la tortuga seguía caminando, paso tras paso, lentamente, pero sin detenerse. No se sabe cuánto tiempo la liebre se quedó dormida, pero cuando ella se despertó, vio con pavor que la tortuga se encontraba a tan solo tres pasos de la meta.En un sobresalto, salió corriendo con todas sus fuerzas, pero ya era muy tarde: ¡la tortuga había alcanzado la meta y ganado la carrera! Ese día la liebre aprendió, en medio de una gran humillación, que no hay que burlarse jamás de los demás.También aprendió que el exceso de confianza y de vanidad, es un obstáculo para alcanzar nuestros objetivos. Y que nadie, absolutamente nadie, es mejor que nadie.";
            switch (titulo)
            {
                case "Patito Feo":
                    cuento= cuento1;
                    break;
                case "Pinocho":
                    cuento = cuento2;
                    break;
                case "liebre":
                    cuento = cuento3;
                    break;
            }
            return cuento;
        }
        public class TipoJuego
        {
            public int idTipoJuego { set; get; }
            public string descTipoJuego { set; get; }
            public string Titulo { set; get; }
        }

    }

}

