using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHoroscopo.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HoroscopoController : Controller
    {

        [HttpGet]
        public string Get(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "error";
            }

            if (mes < 1 || mes > 12)
            {
                return "error";
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            { return "Aries: No podrás complacer nunca a todo el mundo, así que ignora a los que te critiquen."; }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            { return "Un Tauro no tiene mal carácter, sino una personalidad con la que no puedes lidiar."; }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            { return "Geminis: Si las cosas no se hacen bien, no vale la pena hacerlas."; }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            { return "Cancer: Si un Cáncer quiere algo, no parará hasta que lo consiga: espera y obsérvalo con tus propios ojos."; }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            { return "Leo: Nada da más placer en la vida que lograr aquello que dicen que no eres capaz de hacer."; }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            { return "Virgo: No es que sea chismoso... es que soy una persona muy curiosa."; }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            { return "Libra: Puede que ahora todo se esté desmoronando, pero irá bien. Esto también pasará."; }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            { return "Escorpion: Si un Escorpio no confía en alguien, puedes estar seguro de que tiene buenas razones."; }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            { return "Sagitario: Sin riesgo no hay aventura."; }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            { return "Capricornio: Si quieres llevar a cabo una tarea complicada... llama a un Capricornio."; }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            { return "Acuarius: Seguramente no puedas entender del todo bien a un Acuario... no te preocupes, nadie puede."; }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            { return "Piscis:Hago ver que no me entero, pero no te dejes engañar... voy tres pasos por delante tuyo."; }

            return "";
        }

        [HttpPost]
        public string Post([FromHeader]int dia, [FromHeader]int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "error";
            }

            if (mes < 1 || mes > 12)
            {
                return "error";
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            { return "Aries: No podrás complacer nunca a todo el mundo, así que ignora a los que te critiquen."; }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            { return "Un Tauro no tiene mal carácter, sino una personalidad con la que no puedes lidiar."; }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            { return "Geminis: Si las cosas no se hacen bien, no vale la pena hacerlas."; }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            { return "Cancer: Si un Cáncer quiere algo, no parará hasta que lo consiga: espera y obsérvalo con tus propios ojos."; }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            { return "Leo: Nada da más placer en la vida que lograr aquello que dicen que no eres capaz de hacer."; }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            { return "Virgo: No es que sea chismoso... es que soy una persona muy curiosa."; }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            { return "Libra: Puede que ahora todo se esté desmoronando, pero irá bien. Esto también pasará."; }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            { return "Escorpion: Si un Escorpio no confía en alguien, puedes estar seguro de que tiene buenas razones. :("; }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            { return "Sagitario: Sin riesgo no hay aventura."; }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            { return "Capricornio: Si quieres llevar a cabo una tarea complicada... llama a un Capricornio."; }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            { return "Acuarius: Seguramente no puedas entender del todo bien a un Acuario... no te preocupes, nadie puede."; }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            { return "Piscis:Hago ver que no me entero, pero no te dejes engañar... voy tres pasos por delante tuyo."; }

            return "";
        }


    }
}
