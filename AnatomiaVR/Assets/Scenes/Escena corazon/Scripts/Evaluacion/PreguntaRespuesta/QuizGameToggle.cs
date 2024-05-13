using UnityEngine;
using UnityEngine.UI;

public class QuizGameToggle : MonoBehaviour
{
    public Toggle pregunta1Toggle; // Referencia al Toggle de la pregunta 1
    public Toggle verdaderoToggle; // Referencia al Toggle de Verdadero
    public Toggle falsoToggle; // Referencia al Toggle de Falso
    public GameObject imagenVerdadero; // Referencia a la imagen que aparece cuando la respuesta es Verdadero
    public GameObject imagenFalso; // Referencia a la imagen que aparece cuando la respuesta es Falso
    public GameObject imagenIncorrecto; // Referencia a la imagen que aparece cuando la respuesta es Incorrecta

    private bool respuestaCorrecta = true; // Aquí puedes establecer la respuesta correcta para la pregunta 1

    void Start()
    {
        // Configura los Toggles para llamar a las funciones correspondientes cuando cambien
        pregunta1Toggle.onValueChanged.AddListener(delegate { MostrarPregunta(pregunta1Toggle); });
        verdaderoToggle.onValueChanged.AddListener(delegate { ResponderVerdadero(verdaderoToggle); });
        falsoToggle.onValueChanged.AddListener(delegate { ResponderFalso(falsoToggle); });

        // Asegúrate de que las imágenes y los Toggles de respuesta están ocultos al principio
        imagenVerdadero.SetActive(false);
        imagenFalso.SetActive(false);
        imagenIncorrecto.SetActive(false);
        verdaderoToggle.gameObject.SetActive(false);
        falsoToggle.gameObject.SetActive(false);
    }

    void MostrarPregunta(Toggle cambio)
    {
        // Muestra los Toggles de respuesta cuando el Toggle de la pregunta 1 cambia
        if (pregunta1Toggle.isOn)
        {
            verdaderoToggle.gameObject.SetActive(true);
            falsoToggle.gameObject.SetActive(true);
        }
        else
        {
            verdaderoToggle.gameObject.SetActive(false);
            falsoToggle.gameObject.SetActive(false);
        }
    }

    void ResponderVerdadero(Toggle cambio)
    {
        // Muestra la imagen correspondiente cuando el Toggle de Verdadero cambia
        if (verdaderoToggle.isOn)
        {
            if (respuestaCorrecta)
            {
                imagenVerdadero.SetActive(true);
            }
            else
            {
                imagenIncorrecto.SetActive(true);
            }
        }
        else
        {
            imagenVerdadero.SetActive(false);
            imagenIncorrecto.SetActive(false);
        }
    }

    void ResponderFalso(Toggle cambio)
    {
        // Muestra la imagen correspondiente cuando el Toggle de Falso cambia
        if (falsoToggle.isOn)
        {
            if (!respuestaCorrecta)
            {
                imagenFalso.SetActive(true);
            }
            else
            {
                imagenIncorrecto.SetActive(true);
            }
        }
        else
        {
            imagenFalso.SetActive(false);
            imagenIncorrecto.SetActive(false);
        }
    }
}
