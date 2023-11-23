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
        "As queimadas são uma ameaça constante para nossas florestas. Elas destroem habitats, colocam vidas em perigo e contribuem para as mudanças climáticas. Este jogo visa destacar a importância de proteger nossos ecossistemas.",
        "As queimadas têm um impacto terrível na vida selvagem. Milhares de animais perdem seus habitats, enquanto outros sofrem ferimentos graves ou são fatalmente afetados pelo fogo. Ajude nosso herói indígena a salvar essas preciosas vidas.",
        "Muitas queimadas são causadas por ações humanas irresponsáveis, como queimar lixo ou fazer queimadas agrícolas sem o devido cuidado. Esteja ciente das causas e faça sua parte para prevenir incêndios florestais."
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
