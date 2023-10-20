using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    private List<GameText> TextList;

    public TextMeshProUGUI LoreText;

    public Button NextButton;

    public GameObject options;
    public GameObject buttonPrefab;

    public GameText CurrentText;

    void Awake()
    {
        TextList = new List<GameText>();
        OptionText option;

        GameText GameText1 = new GameText("Te encuentras secuestrado en un sotano, no sabes como llegaste ahi, pero sientes que solo debes escapar");
        TextList.Add(GameText1);

        DecideText DecideText1 = new DecideText("Tus brazos estan atados a una silla ");
        GameText1.NextText(DecideText1);
        TextList.Add(DecideText1);

        GameText GameText2 = new GameText("Rompes la soga con facilidad");
        TextList.Add(GameText2);

        GameText GameText3 = new GameText("No logras romper la soga a la primera, lo logar al 4 intento y te dañaste tus muñecas");
        TextList.Add(GameText3);

        GameText GameText4 = new GameText("Fuiste lo suficientemente habil para desamarrarte");
        TextList.Add(GameText4);

        GameText GameText5 = new GameText("El nudo fue muy dificil para ti y te hizo daño en los dedos");
        TextList.Add(GameText5);

        option = new Strength(15, 8, "Romper la soga a la fuerza");
        DecideText1.AddOption(option);
        option.SetCallback(
            () => { DecideText1.NextText(GameText2); Next(); },
            () => { DecideText1.NextText(GameText3); Next(); });

        option = new Dextery(10, 2, "Tratar de desamarrarte");
        DecideText1.AddOption(option);
        option.SetCallback(
            () => { DecideText1.NextText(GameText4); Next(); },
            () => { DecideText1.NextText(GameText5); Next(); });

        GameText GameText6 = new GameText("Sales del sotano y vez: una escalera hacia el segundo piso, una sala de estar y la cocina");

        GameText2.NextText(GameText6);
        GameText3.NextText(GameText6);
        GameText4.NextText(GameText6);
        GameText5.NextText(GameText6);

        DecideText DecideText2 = new DecideText("¿A donde quieres ir?");
        GameText6.NextText(DecideText2);
        TextList.Add(DecideText2);

        GameText GameText7 = new GameText("Subes al segundo piso");
        TextList.Add(GameText7);

        GameText GameText8 = new GameText("Vas a la sala");
        TextList.Add(GameText8);

        GameText GameText9 = new GameText("Entras a la cocina");
        TextList.Add(GameText9);

        option = new Strength(0, 0, "Segundo piso");
        DecideText2.AddOption(option);
        option.SetCallback(
            () => { DecideText2.NextText(GameText7); Next(); },
            () => { DecideText2.NextText(GameText7); Next(); });

        option = new Strength(0, 0, "Sala de estar");
        DecideText2.AddOption(option);
        option.SetCallback(
            () => { DecideText2.NextText(GameText8); Next(); },
            () => { DecideText2.NextText(GameText8); Next(); });

        option = new Strength(0, 0, "Cocina");
        DecideText2.AddOption(option);
        option.SetCallback(
            () => { DecideText2.NextText(GameText9); Next(); },
            () => { DecideText2.NextText(GameText9); Next(); });

        GameText GameText10 = new GameText("Miras rapidamente hacia los lados, y sigues un pasillo hasta llegar a una habitacion con una ventana, una cama y varios muebles");
        GameText7.NextText(GameText10);
        TextList.Add(GameText10);

        GameText GameText11 = new GameText("Vas a la sala y buscas por donde salir");
        GameText8.NextText(GameText11);
        TextList.Add(GameText11);

        GameText GameText12 = new GameText("En la cocina buscas algun lugar por donde salir");
        GameText9.NextText(GameText12);
        TextList.Add(GameText12);

        //Segundo piso

        GameText GameText13 = new GameText("Escuchas unas pisadas llendo a donde te encuentras");
        GameText10.NextText(GameText13);
        TextList.Add(GameText13);

        GameText GameText14 = new GameText("Te escondes debajo de la cama y vez a una persona entrar al cuarto");
        GameText13.NextText(GameText14);
        TextList.Add(GameText14);

        GameText GameText15 = new GameText("Ves como la persona empieza a buscarte en el cuarto");
        GameText14.NextText(GameText15);
        TextList.Add(GameText15);

        DecideText DecideText3 = new DecideText("¿Que haces?");
        GameText15.NextText(DecideText3);
        TextList.Add(DecideText3);

        //Deciciones
               
        GameText GameText16 = new GameText("Peleas con el secuestrador y lo noqueas facilmente, huyes rapidamente");
        TextList.Add(GameText16);

        GameText GameText17 = new GameText("El secuestrador te golpea varias veces y te deja muy dañado, pero lo empujas y este se noquea al chocar con un mueble");
        TextList.Add(GameText17);

        GameText GameText18 = new GameText("Corres y saltas por la ventana cuando el secuestrador mira a otro lado, caes bien y ileso");
        TextList.Add(GameText18);

        GameText GameText19 = new GameText("Corres y saltas torpemente por la ventana cuando el secuestrador mira a otro lado, al tropesarte caes mal haciendote mucho daño");
        TextList.Add(GameText19);

        option = new Strength(20, 20, "Pelear contra la persona");
        DecideText3.AddOption(option);
        option.SetCallback(
            () => { DecideText3.NextText(GameText16); Next(); },
            () => { DecideText3.NextText(GameText17); Next(); });

        option = new Dextery(30, 35, "Escapar por la ventana");
        DecideText3.AddOption(option);
        option.SetCallback(
            () => { DecideText3.NextText(GameText18); Next(); },
            () => { DecideText3.NextText(GameText19); Next(); });

        GameText GameText20 = new GameText("Lograste escapar, Felicidades FINAL 1/3");

        GameText16.NextText(GameText20);
        GameText17.NextText(GameText20);
        GameText18.NextText(GameText20);



        //Sala

        GameText GameText21 = new GameText("Escuchas unas pisadas llendo a donde te encuentras y te escondes detras del mueble");
        GameText11.NextText(GameText21);
        TextList.Add(GameText21);

        GameText GameText22 = new GameText("Ves al secuestrador buscandote por los alrededores");
        GameText21.NextText(GameText22);
        TextList.Add(GameText22);

        GameText GameText23 = new GameText("En la sala vez un hacha colgada en la pared como decoracion pero se ve pesada y tambien te das cuenta que puedes hacer una distraccion para escapar de ahi");
        GameText22.NextText(GameText23);
        TextList.Add(GameText23);

        DecideText DecideText4 = new DecideText("¿Que haces?");
        GameText23.NextText(DecideText4);
        TextList.Add(DecideText4);

        //Deciciones

        GameText GameText24 = new GameText("Peleas con el secuestrador usando el hacha pero el fue mas habil que tu, y te apuñalo con un cuchillo");
        TextList.Add(GameText24);

        GameText GameText25 = new GameText("El hacha es muy pesada para ti, el secuestrador aprovecha eso y te apuñala con su cuchillo");
        TextList.Add(GameText25);

        GameText GameText26 = new GameText("Con tu zapatilla haces una distraccion, haciendo que el secuestrador valla y sales de ahi corriendo");
        TextList.Add(GameText26);

        GameText GameText27 = new GameText("Con tu zapatilla haces una distraccion, haciendo que el secuestrador valla, pero te resbalas y el secuestrador llega a atraparte");
        TextList.Add(GameText27);

        option = new Strength(30, 30, "Usar el Hacha");
        DecideText4.AddOption(option);
        option.SetCallback(
            () => { DecideText4.NextText(GameText24); Next(); },
            () => { DecideText4.NextText(GameText25); Next(); });

        option = new Dextery(30, 30, "Distraccion");
        DecideText4.AddOption(option);
        option.SetCallback(
            () => { DecideText4.NextText(GameText26); Next(); },
            () => { DecideText4.NextText(GameText27); Next(); });

        GameText GameText28 = new GameText("Haz muerto FINAL 2/3");
        GameText24.NextText(GameText28);
        GameText25.NextText(GameText28);
        GameText26.NextText(GameText20);


        //Cocina

        GameText GameText29 = new GameText("Escuchas unas pisadas llendo a donde te encuentras");
        GameText12.NextText(GameText29);
        TextList.Add(GameText29);

        GameText GameText30 = new GameText("Ves al secuestrador buscandote por los alrededores");
        GameText29.NextText(GameText30);
        TextList.Add(GameText30);

        GameText GameText31 = new GameText("Puedes agarrar un cuchillo de la cocina y pelear o tirarle varias ollas y aprovechar en escapar");
        GameText30.NextText(GameText31);
        TextList.Add(GameText31);

        DecideText DecideText5 = new DecideText("¿Que haces?");
        GameText31.NextText(DecideText5);
        TextList.Add(DecideText5);

        //Deciciones

        GameText GameText32 = new GameText("Peleas con el secuestrador usando un cuchillo y lo apuñalas, te vas corriendo de ahi");
        TextList.Add(GameText32);

        GameText GameText33 = new GameText("El secuestrador peleo mejor que tu, te quito el cuchillo tu te apuñalo");
        TextList.Add(GameText33);

        GameText GameText34 = new GameText("Le tiras las ollas al secuestrador distrayendolo y llegaste a escapar");
        TextList.Add(GameText34);

        GameText GameText35 = new GameText("Le tiras las ollas al secuestrador distrayendolo, pero cuando corres te tropiezas y te vuelve a atrapar");
        TextList.Add(GameText35);

        option = new Strength(25, 25, "Agarrar un cuchillo y pelear");
        DecideText5.AddOption(option);
        option.SetCallback(
            () => { DecideText5.NextText(GameText32); Next(); },
            () => { DecideText5.NextText(GameText33); Next(); });

        option = new Dextery(35, 30, "Tirarle varias ollas");
        DecideText5.AddOption(option);
        option.SetCallback(
            () => { DecideText5.NextText(GameText34); Next(); },
            () => { DecideText5.NextText(GameText35); Next(); });

        GameText GameText36 = new GameText("Te volvieron a atrapar, tu futuro es incierto FINAL 3/3");
        GameText19.NextText(GameText36);
        GameText27.NextText(GameText28);
        GameText32.NextText(GameText20);
        GameText33.NextText(GameText28);
        GameText34.NextText(GameText20);
        GameText35.NextText(GameText36);


        CurrentText = TextList[0];
        LoreText.text = CurrentText.Text;
        NextButton.onClick.AddListener(Next);
    }


    private void Next()
    {

        CurrentText = CurrentText.NextDialogue;

        LoreText.text = CurrentText.Text;
        if (CurrentText is DecideText)
        {
            foreach (OptionText option in ((DecideText)CurrentText).OptionList)
            {
                GameObject button = Instantiate(buttonPrefab);
                button.transform.SetParent(options.transform);
                button.GetComponentInChildren<TextMeshProUGUI>().text = option.Text;
                button.GetComponent<Button>().onClick.AddListener(() =>
                {
                    option.Decide();
                    foreach (Transform child in options.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
                );
            }
        }
    }
}
