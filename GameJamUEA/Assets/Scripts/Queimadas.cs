using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Queimadas : MonoBehaviour
{

    public TextMeshProUGUI text;

    List<string> textos = new List<string>() 
    {
        "As queimadas s�o uma amea�a constante para nossas florestas. Elas destroem habitats, colocam vidas em perigo e contribuem para as mudan�as clim�ticas. Este jogo visa destacar a import�ncia de proteger nossos ecossistemas.",
        "As queimadas t�m um impacto terr�vel na vida selvagem. Milhares de animais perdem seus habitats, enquanto outros sofrem ferimentos graves ou s�o fatalmente afetados pelo fogo. Ajude nosso her�i ind�gena a salvar essas preciosas vidas.",
        "Muitas queimadas s�o causadas por a��es humanas irrespons�veis, como queimar lixo ou fazer queimadas agr�colas sem o devido cuidado. Esteja ciente das causas e fa�a sua parte para prevenir inc�ndios florestais."
    };

    public void Proximo()
    {
        if (textos.Count != 0)
        {
            text.text = textos.First<string>();
            textos.RemoveAt(0);
        }
        else
        {
            // Chamar outra cena ou algo tipo
        }
    }
}
