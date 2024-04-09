## Blog
Questa è un applicazione in Blazor, un framework per la creazione di applicazioni web interattive con .NET e C#.
# Scaricare e avviare il progetto
  * Da link repository:

    **Andare alla pagina GitHub: https://github.com/Mich120201/Script_phyton_blog**
    
      * Aprire Visual Studio Community;
        
      * Selezionare "Clona una repository";
        
      * Inserire il link della repository: https://github.com/Mich120201/Script_phyton_blog.git
      
      * Selezionare il file "PythonApplication1.snl"
          
      * Scaricare MySQL Workbench e creare un database di nome "blog";
          
      * Cambiare nel file "PythonApplication1.py" le credenziali per entrare nel server sql, per l'user sostituire "root" e per la password "Ciao1234";
          
      * Premere F5 o in caso non funzioni Fn+F5;
   
      **Andare sulla pagina di Github https://github.com/Intelliware-s-r-l/Blog**
    
      * Aprire Visual Studio Community;
        
      * Selezionare "Clona una repository";
    
      * Inserire il link della repository: https://github.com/Intelliware-s-r-l/Blog.git;
    
      * Selezionare il file Blog.snl

      * Andare nel file "appsettings.json" e cambiare nella riga "AppDbConnectionString" l'user e la password per connettersi al database precedentemente creato;
          
      * Premere F5 o in caso non funzioni Fn+F5;
      
  * Da file ZIP:
    
      **Andare alla pagina GitHub: https://github.com/Mich120201/Script_phyton_blog**
    
      * Dal bottone "Code <>" selezionare l'opzione "Download ZIP";
         
      * Estrarre i file dalla cartella ZIP;
         
      * Aprire Visula Studio Community;
    
      * Selezionare l'opzione "Aprire cartella locale";
         
      * Selezionare la cartella appena estratta;
         
      * Selezionare il file "PythonApplication1.snl"
          
      * Scaricare MySQL Workbench e creare un database di nome "blog";
          
      * Cambiare nel file "PythonApplication1.py" le credenziali per entrare nel server sql, per l'user sostituire "root" e per la password "Ciao1234";
          
      * Premere F5 o in caso non funzioni Fn+F5;
         
      **Andare sulla pagina di Github https://github.com/Intelliware-s-r-l/Blog**
    
      * Dal bottone "Code <>" selezionare l'opzione "Download ZIP";
   
      * Estrarre i file dalla cartella ZIP;

      * Aprire Visula Studio Community;

      * Selezionare l'opzione "Aprire cartella locale";
    
      * Selezionare la cartella appena estratta;
          
      * Selezionare il file Blog.snl;
          
      * Andare nel file "appsettings.json" e cambiare nella riga "AppDbConnectionString" l'user e la password per connettersi al database precedentemente creato;
          
      * Premere F5 o in caso non funzioni Fn+F5;
          
# Descrizione progetto
  * Pagina "Home":
    La pagina è progettata per visualizzare una serie di post di un blog.
    * parte superiore del file:
         •	@page "/" indica che questa è la pagina principale dell'applicazione.
       
         ![Screenshot 2024-04-08 151309](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/44c7b709-61df-440b-8bcf-97c25b4f6d86)
       
         •	@inject HttpClient Http inietta un'istanza di HttpClient che può essere utilizzata per fare richieste HTTP.
         •	@using importa vari namespace necessari per il codice.
       
         ![Screenshot 2024-04-08 151317](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/4edffd66-da2f-4496-bf3c-9cf21c1337a1)
       
         •	Il blocco <style> contiene i CSS per la formattazione della pagina.
       
         ![Screenshot 2024-04-08 151403](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/e0a68fad-8646-45bd-96d2-42234ad923a3)
         ![Screenshot 2024-04-08 151422](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/9648e624-3975-4a0b-b983-bb3e08189077)
       
    * Nel corpo della pagina, c'è un controllo if che verifica se posts è null. Se non lo è, il codice itera sui post e li visualizza in vari modi. Se posts è null, viene visualizzato un messaggio di caricamento:
   
       ![Screenshot 2024-04-08 152307](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/9de8ef8c-8527-497e-aa5c-ef77011f12ed)
       ![Screenshot 2024-04-08 152004](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/b14d0c61-1361-4fbc-becf-be3caa26a4f5)

         •	Il primo post viene visualizzato come un banner con un'immagine di sfondo, un titolo e una descrizione.
   
       ![Screenshot 2024-04-08 151850](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/a237e4bf-5c23-4d53-8968-a7c666905f96)

         •	I successivi due post vengono visualizzati in una griglia a due colonne con immagini, titoli, descrizioni e pulsanti.
   
       ![Screenshot 2024-04-08 151943](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/89b4e92d-5989-402f-972f-f80ba9036a7f)

         •	I post successivi vengono visualizzati in una lista con titoli, descrizioni e link.

        ![Screenshot 2024-04-08 151954](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/d018de42-1647-4c26-9577-38b3869adf3a)

    * Infine, nel blocco @code:
         •	private Post[]? posts; dichiara un array di post che può essere null.
         •	OnInitializedAsync è un metodo del ciclo di vita del componente che viene chiamato quando il componente viene inizializzato. In questo metodo, l'applicazione fa una richiesta GET all'endpoint api/Post             per ottenere i post e li assegna all'array posts.

       ![Screenshot 2024-04-08 152010](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/5bcc2bf9-4aa7-4740-a916-8d9bfba7acc3)

![Immagine 2024-04-08 154740](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/5358fdf7-10ac-4bbb-8f1d-ec4cf6740113)
![Immagine 2024-04-08 154806](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/2121034b-f383-4c1d-827a-6c398880fe3b)


  * Pagina "Chi Sono":
    La pagina è progettata per visualizzare informazioni sull'autore del blog. Ci si può navigare cliccando sul pulsante "Chi sono" posto in alto al centro della pagina "Home".
    * parte superiore del file:

         •	@page "/about_me" indica che questa è la pagina "About Me" dell'applicazione, accessibile tramite l'URL "/about_me".

        ![Screenshot 2024-04-08 152931](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/82538710-a6bd-49ea-8d44-99d6942849e2)

         •	@using MudBlazor importa il namespace MudBlazor, che è una libreria di componenti per Blazor.

        ![Screenshot 2024-04-08 152938](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/0b301942-80fa-463c-a50d-b63c2b9f2bc4)

         •	Il blocco <style> contiene i CSS per la formattazione della pagina.
       
        ![Screenshot 2024-04-08 152944](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/2fd14d8d-b454-47f7-b912-f38f28da31e7)

    * Nel corpo della pagina, c'è un div con la classe "post" che contiene un div con la classe "text". Questo div "text" contiene vari elementi h1, h3 e p che forniscono informazioni sull'autore del blog:
       
         •	L'elemento h1 contiene il titolo "Chi sono?".
       
         •	Gli elementi p contengono vari paragrafi di testo che descrivono l'autore, la sua esperienza come veterinario, una storia significativa che ha vissuto e il motivo per cui ha iniziato il blog.
       
         •	Gli elementi h3 fungono da sottotitoli per le varie sezioni del testo.

       ![Screenshot 2024-04-08 153114](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/26c17f9a-252e-4779-9b2d-fef745c92757)

![Screenshot 2024-04-08 155103](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/542da2a6-e980-453e-8c93-0941d805e2e7)
![Screenshot 2024-04-08 155137](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/1d374c88-2611-44cf-8516-140049ca48d1)


  * Pagina "Nuovo Post":
    La pagina è progettata per permettere agli amministratori di creare nuovi post per il blog. Ci si può navigare cliccando sul bottone "Nuovo Post" posto in alto a destra della pagina "Home".
    * parte superiore del file:
         •	@page "/newpost" indica che questa è la pagina "New Post" dell'applicazione, accessibile tramite l'URL "/newpost".

        ![Screenshot 2024-04-08 153240](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/fea74623-74f4-4f89-b06f-cbc988ae5b63)

         •	@inject HttpClient Http inietta un'istanza di HttpClient che può essere utilizzata per fare richieste HTTP.
       
         •	@using importa vari namespace necessari per il codice.

        ![Screenshot 2024-04-08 153246](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/1efa9362-9a04-4a9e-b2e3-6cf2578277c3)

         •	Il blocco <style> contiene i CSS per la formattazione della pagina.

       ![Screenshot 2024-04-08 153533](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/a156b2e1-bded-41d9-bb6e-5206338f69c3)
       ![Screenshot 2024-04-08 153309](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/1201b4c4-3af0-4c2c-b240-0395a9ea66d1)

    * Nel corpo della pagina, c'è un controllo if che verifica se l'utente è un amministratore. Se non lo è, viene visualizzato un modulo di login. Se l'utente è un amministratore, viene visualizzato un modulo          per la creazione di un nuovo post:
         •	Il modulo di login richiede un nome utente e una password. Se le credenziali sono errate, viene visualizzato un messaggio di errore.
       
         •	Il modulo per la creazione di un nuovo post richiede un titolo, un contenuto, un tipo e un URL per il post. Ci sono anche pulsanti per aggiungere il post o cancellare il modulo.

       ![Screenshot 2024-04-08 153323](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/b62ed5f8-eef4-460b-a1e4-ad16471b5c13)

    * Infine, nel blocco @code:
         •	Ci sono vari campi per memorizzare le informazioni inserite nel modulo e i dati degli utenti.
       
         •	Check è un metodo che verifica le credenziali dell'utente e imposta Admin a true se l'utente è un amministratore. Le credenziali per l'unico admin che ha l'accesso sono: User(mich), Password(Ciao1234).
       
         •	AddPost è un metodo che crea un nuovo post con le informazioni inserite nel modulo e lo invia all'endpoint api/Post.
       
         •	Cancel è un metodo che cancella le informazioni inserite nel modulo.

       ![Screenshot 2024-04-08 153349](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/abf590bd-29af-4882-a584-504d12913af9)

![Immagine 2024-04-08 155411](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/006be8d1-d88b-48ba-a403-3fffbe945d07)
![Immagine 2024-04-08 155328](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/0a8d4325-ca47-4990-bdce-27669f1ccf3f)
![Screenshot 2024-04-08 155348](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/f106388b-e397-48b3-afdf-b27826a267da)


  * Pagina "Leggi l'articolo":
    La pagina è progettata per visualizzare un post specifico del blog. Ci si può accedere cliccando su uno dei pulsanti "Leggi l'articolo" posti al di sotto dei post visualizzati nella pagina "Home".
    * parte superiore del file:
         •	@page "/{id}" indica che questa è una pagina dinamica che può essere accessibile tramite un URL che include un ID, come "/123".

        ![Screenshot 2024-04-08 153934](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/e678fb4c-90e5-4a0a-8e81-ad79bec89ba8)

         •	@inject HttpClient Http inietta un'istanza di HttpClient che può essere utilizzata per fare richieste HTTP.
       
         •	@using importa vari namespace necessari per il codice.

        ![Screenshot 2024-04-08 154126](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/95faec17-5396-4535-bb09-438ff642a98d)

         •	Il blocco <style> contiene i CSS per la formattazione della pagina.

       ![Screenshot 2024-04-08 153958](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/3e2952cf-3c11-400a-a055-aa3c23b884d9)

    * Nel corpo della pagina, c'è un controllo if che verifica se post è null. Se non lo è, il codice visualizza il titolo e la descrizione del post. Se post è null, viene visualizzato un messaggio che indica           che il post non è stato trovato.

       ![Screenshot 2024-04-08 154012](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/6461fa20-bcb4-4808-9edb-6e9e0d1cd0ce)

    * Infine, nel blocco @code:
         •	id è un parametro che contiene l'ID del post da visualizzare.
       
         •	post è una variabile che contiene il post da visualizzare.
       
         •	OnInitializedAsync è un metodo del ciclo di vita del componente che viene chiamato quando il componente viene inizializzato. In questo metodo, l'applicazione fa una richiesta GET all'endpoint                      api/Post/{postId} per ottenere il post e assegna il risultato a post. Fa anche richieste GET agli endpoint api/Commenti e api/Risposte per ottenere i commenti e le risposte.

       ![Screenshot 2024-04-08 154050](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/02ccac51-5478-42c6-8556-22e76e813e41)

![Immagine 2024-04-08 155548](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/e528d1f4-9dea-43c0-8fa5-b01b39a3039f)

  * Pagina "MainLayout":
    Questa è la definizione del layout principale per un'applicazione Blazor. Il layout principale è un componente speciale che viene utilizzato per definire la struttura comune delle pagine dell'applicazione.        Questo layout definisce la struttura comune delle pagine dell'applicazione, che include il menu di navigazione e un'area per il contenuto specifico della pagina. Tutte le pagine che utilizzano questo layout       avranno la stessa struttura, ma con contenuti diversi. Questa pagina non è visuallizzabile in quanto è solo un contenitore per la struttura base delle pagine che verranno visualizzate.
    * parte superiore:
         •	@using MudBlazor importa il namespace MudBlazor, che è una libreria di componenti per Blazor.
       
         •	@inherits LayoutComponentBase indica che questo componente eredita da LayoutComponentBase, che è la classe base per i layout in Blazor.

        ![Screenshot 2024-04-08 154257](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/c051ba35-0e7d-4172-ab26-321e4a0eb860)

         •	Il blocco <style> contiene i CSS per la formattazione del layout.

       ![Screenshot 2024-04-08 154305](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/55c6a5ce-1cc5-49bc-aacd-fb7355822b97)

    * Nel corpo del layout, c'è un div con la classe "page" che contiene il menu di navigazione e il contenuto principale dell'applicazione.
         •	NavMenu è un componente che viene utilizzato per visualizzare il menu di navigazione. Questo componente viene visualizzato in tutte le pagine che utilizzano questo layout.
       
         •	Il tag <main> contiene un <article> con la classe "content" e un padding di 4 unità. Questo è dove il contenuto specifico di ogni pagina viene visualizzato.
       
         •	@Body è un segnaposto che viene sostituito con il contenuto specifico di ogni pagina.

       ![Screenshot 2024-04-08 154313](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/aca92096-53b1-4e77-ab11-13d2b27c397d)

  * Pagina "NavMenu"
    Questa è la definizione del menu di navigazione per un'applicazione Blazor. Il menu di navigazione è un componente speciale che viene utilizzato per navigare tra le diverse pagine dell'applicazione. Questo        componente definisce il menu di navigazione dell'applicazione, che include link alla homepage, alla pagina "About Me" e alla pagina "New Post". Quando l'utente clicca su uno di questi link, l'applicazione         naviga alla pagina corrispondente.
    * parte superiore:
         •	@using importa vari namespace necessari per il codice.
       
         •	@inject NavigationManager NavManager e @inject IJSRuntime JSRuntime iniettano un'istanza di NavigationManager e IJSRuntime che possono essere utilizzate per la navigazione e l'esecuzione di codice                 JavaScript, rispettivamente.

        ![Screenshot 2024-04-08 154424](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/3020b727-963f-4616-92d9-f9aa6e105169)

         •	Il blocco <style> contiene i CSS per la formattazione del menu di navigazione.

       ![Screenshot 2024-04-08 154537](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/2cb1ee69-a4f7-4b2f-b33a-2d8c977a4610)

    * Nel corpo del componente, c'è un elemento <nav> che contiene tre div: "nav-left", "nav-center" e "nav-right":
         •	"nav-left" contiene un elemento <text> che visualizza il titolo "Storie di Coda".
       
         •	"nav-center" contiene due link, "Home" e "Chi Sono", che portano rispettivamente alla homepage e alla pagina "About Me".
       
         •	"nav-right" contiene un link a "/newpost" con un pulsante "Nuovo Post".

       ![Screenshot 2024-04-08 154450](https://github.com/Intelliware-s-r-l/Blog/assets/97882894/eb4a36aa-7d74-4286-a95b-8cd65422e001)
