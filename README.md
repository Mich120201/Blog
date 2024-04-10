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
       
         ![Screenshot 2024-04-10 105249](https://github.com/Mich120201/Blog/assets/97882894/9f8b503f-7ba9-44e5-b46e-74bbe9580d04)
      
         •	@inject HttpClient Http inietta un'istanza di HttpClient che può essere utilizzata per fare richieste HTTP.
         •	@using importa vari namespace necessari per il codice.
       
         ![Screenshot 2024-04-10 105256](https://github.com/Mich120201/Blog/assets/97882894/a0718b80-acf2-455c-b0a2-555fd1563652)
       
         •	Il blocco <style> contiene i CSS per la formattazione della pagina.
       
         ![Screenshot 2024-04-10 105358](https://github.com/Mich120201/Blog/assets/97882894/42ac90dd-8897-4054-9f32-76bd81d6b7ed)
         ![Screenshot 2024-04-10 105409](https://github.com/Mich120201/Blog/assets/97882894/992fa728-115d-45fd-8709-e2091e6e74ff)
       
    * Nel corpo della pagina, c'è un controllo if che verifica se posts è null. Se non lo è, il codice itera sui post e li visualizza in vari modi. Se posts è null, viene visualizzato un messaggio di caricamento:
   
         ![Screenshot 2024-04-10 105420](https://github.com/Mich120201/Blog/assets/97882894/d5dc186f-cfae-4786-8929-3a5010e8936d)
         ![Screenshot 2024-04-10 105428](https://github.com/Mich120201/Blog/assets/97882894/ebf074b6-8e7b-4ea9-8452-983cc6a7b137)

         •	Il primo post viene visualizzato come un banner con un'immagine di sfondo, un titolo e una descrizione.
   
         ![Screenshot 2024-04-10 105436](https://github.com/Mich120201/Blog/assets/97882894/ead4f6bd-5a44-4d7b-bdf4-b87c65d9055f)

         •	I successivi due post vengono visualizzati in una griglia a due colonne con immagini, titoli, descrizioni e pulsanti.
   
         ![Screenshot 2024-04-10 105449](https://github.com/Mich120201/Blog/assets/97882894/dd09c0f8-32d4-49c2-9f6c-ac6bd73e1b76)

         •	I post successivi vengono visualizzati in una lista con titoli, descrizioni e link.

         ![Screenshot 2024-04-10 105510](https://github.com/Mich120201/Blog/assets/97882894/4f6dcf89-1dfc-4c42-9c88-57557eeca5cf)

    * Infine, nel blocco @code:
         •	private Post[]? posts; dichiara un array di post che può essere null.
         •	OnInitializedAsync è un metodo del ciclo di vita del componente che viene chiamato quando il componente viene inizializzato. In questo metodo, l'applicazione fa una richiesta GET all'endpoint api/Post             per ottenere i post e li assegna all'array posts.

         ![Screenshot 2024-04-10 112403](https://github.com/Mich120201/Blog/assets/97882894/6082a55a-c3e3-4de6-a82a-c20ab120dac7)

![Screenshot 2024-04-10 112823](https://github.com/Mich120201/Blog/assets/97882894/18798cbd-62ec-4e75-a3eb-9e19ed68f918)
![Screenshot 2024-04-10 112847](https://github.com/Mich120201/Blog/assets/97882894/005d3318-54d1-465e-be9b-ffb758b5db56)

  * Pagina "Chi Sono":
    La pagina è progettata per visualizzare informazioni sull'autore del blog. Ci si può navigare cliccando sul pulsante "Chi sono" posto in alto al centro della pagina "Home".
    * parte superiore del file:

         •	@page "/about_me" indica che questa è la pagina "About Me" dell'applicazione, accessibile tramite l'URL "/about_me".

        ![Screenshot 2024-04-10 113644](https://github.com/Mich120201/Blog/assets/97882894/c0ad9491-1362-422b-b039-4f6565c0258b)

         •	@using MudBlazor importa il namespace MudBlazor, che è una libreria di componenti per Blazor.

        ![Screenshot 2024-04-10 113652](https://github.com/Mich120201/Blog/assets/97882894/52c1ef3e-b976-4159-af9d-4e52900bda54)

         •	Il blocco <style> contiene i CSS per la formattazione della pagina.
       
        ![Screenshot 2024-04-10 113701](https://github.com/Mich120201/Blog/assets/97882894/c8014028-c9a0-444d-bfe3-83fea1e1a479)

    * Nel corpo della pagina, c'è un div con la classe "post" che contiene un div con la classe "text". Questo div "text" contiene vari elementi h1, h3 e p che forniscono informazioni sull'autore del blog:
       
         •	L'elemento h1 contiene il titolo "Chi sono?".
       
         •	Gli elementi p contengono vari paragrafi di testo che descrivono l'autore, la sua esperienza come veterinario, una storia significativa che ha vissuto e il motivo per cui ha iniziato il blog.
       
         •	Gli elementi h3 fungono da sottotitoli per le varie sezioni del testo.

       ![Screenshot 2024-04-10 113740](https://github.com/Mich120201/Blog/assets/97882894/03581585-8d40-4ca8-9c0b-d6188667d977)

![Screenshot 2024-04-10 113757](https://github.com/Mich120201/Blog/assets/97882894/f6e7726a-0207-487c-b645-fd6c0869782f)
![Screenshot 2024-04-10 113811](https://github.com/Mich120201/Blog/assets/97882894/f17a5cd6-dd75-4c74-993d-1dc8cc1a94f9)

  * Pagina "Nuovo Post":
    La pagina è progettata per permettere agli amministratori di creare nuovi post per il blog. Ci si può navigare cliccando sul bottone "Nuovo Post" posto in alto a destra della pagina "Home".
    * parte superiore del file:
         •	@page "/newpost" indica che questa è la pagina "New Post" dell'applicazione, accessibile tramite l'URL "/newpost".

        ![Screenshot 2024-04-10 114117](https://github.com/Mich120201/Blog/assets/97882894/9f337afe-abd8-44c9-ac7a-0443c7d11012)

         •	@inject HttpClient Http inietta un'istanza di HttpClient che può essere utilizzata per fare richieste HTTP.
       
         •	@using importa vari namespace necessari per il codice.

        ![Screenshot 2024-04-10 114136](https://github.com/Mich120201/Blog/assets/97882894/eb22ea7b-e084-4a80-99e6-b4778899d4c7)

         •	Il blocco <style> contiene i CSS per la formattazione della pagina.

        ![Screenshot 2024-04-10 114333](https://github.com/Mich120201/Blog/assets/97882894/b8c53a98-bcbb-4746-8058-06575f096109)
        ![Screenshot 2024-04-10 114346](https://github.com/Mich120201/Blog/assets/97882894/0363c285-7106-4906-bb88-82aee7de42fc)

    * Nel corpo della pagina, c'è un controllo if che verifica se l'utente è un amministratore. Se non lo è, viene visualizzato un modulo di login. Se l'utente è un amministratore, viene visualizzato un modulo          per la creazione di un nuovo post:
         •	Il modulo di login richiede un nome utente e una password. Se le credenziali sono errate, viene visualizzato un messaggio di errore.
       
         •	Il modulo per la creazione di un nuovo post richiede un titolo, un contenuto, un tipo e un URL per il post. Ci sono anche pulsanti per aggiungere il post o cancellare il modulo.

       ![Screenshot 2024-04-10 114520](https://github.com/Mich120201/Blog/assets/97882894/a98a91a4-e1af-4208-a1d8-f07d890bca02)

    * Infine, nel blocco @code:
         •	Ci sono vari campi per memorizzare le informazioni inserite nel modulo e i dati degli utenti.
       
         •	Check è un metodo che verifica le credenziali dell'utente e imposta Admin a true se l'utente è un amministratore. Le credenziali per l'unico admin che ha l'accesso sono: User(mich), Password(Ciao1234).
       
         •	AddPost è un metodo che crea un nuovo post con le informazioni inserite nel modulo e lo invia all'endpoint api/Post.
       
         •	Cancel è un metodo che cancella le informazioni inserite nel modulo.

       ![Screenshot 2024-04-10 114532](https://github.com/Mich120201/Blog/assets/97882894/b64a99d3-663b-47a9-8b7e-dda6a077956f)

![Screenshot 2024-04-10 114853](https://github.com/Mich120201/Blog/assets/97882894/8b454635-b7d8-4a23-81de-0b3dd8cffb3c)
![Screenshot 2024-04-10 114930](https://github.com/Mich120201/Blog/assets/97882894/69508c89-5c60-4f2b-aa0d-7d443bb8137a)

  * Pagina "Leggi l'articolo":
    La pagina è progettata per visualizzare un post specifico del blog. Ci si può accedere cliccando su uno dei pulsanti "Leggi l'articolo" posti al di sotto dei post visualizzati nella pagina "Home".
    * parte superiore del file:
         •	@page "/{id}" indica che questa è una pagina dinamica che può essere accessibile tramite un URL che include un ID, come "/123".

        ![Screenshot 2024-04-10 115309](https://github.com/Mich120201/Blog/assets/97882894/dc5d837a-cacd-4d2d-a723-8aa13d922147)

         •	@inject HttpClient Http inietta un'istanza di HttpClient che può essere utilizzata per fare richieste HTTP.
       
         •	@using importa vari namespace necessari per il codice.

        ![Screenshot 2024-04-10 115315](https://github.com/Mich120201/Blog/assets/97882894/7a9a2bca-ec99-45ea-b649-0698c5cb671b)

         •	Il blocco <style> contiene i CSS per la formattazione della pagina.

        ![Screenshot 2024-04-10 115333](https://github.com/Mich120201/Blog/assets/97882894/fac5680b-d79e-4f4c-97f4-bc3267199f73)

    * Nel corpo della pagina, c'è un controllo if che verifica se post è null. Se non lo è, il codice visualizza il titolo e la descrizione del post. Se post è null, viene visualizzato un messaggio che indica           che il post non è stato trovato.

       ![Screenshot 2024-04-10 115344](https://github.com/Mich120201/Blog/assets/97882894/8db2f5e6-be4c-46bf-baa4-3e2f0f5e9999)

    * Infine, nel blocco @code:
         •	id è un parametro che contiene l'ID del post da visualizzare.
       
         •	post è una variabile che contiene il post da visualizzare.
       
         •	OnInitializedAsync è un metodo del ciclo di vita del componente che viene chiamato quando il componente viene inizializzato. In questo metodo, l'applicazione fa una richiesta GET all'endpoint                      api/Post/{postId} per ottenere il post e assegna il risultato a post.
      
       ![Screenshot 2024-04-10 115352](https://github.com/Mich120201/Blog/assets/97882894/1cc0b5b0-1009-41b6-afef-c3a79cd1998f)

![Screenshot 2024-04-10 115803](https://github.com/Mich120201/Blog/assets/97882894/6a1854d8-96cc-4077-b228-283a42b0e7c1)

  * Pagina "MainLayout":
    Questa è la definizione del layout principale per un'applicazione Blazor. Il layout principale è un componente speciale che viene utilizzato per definire la struttura comune delle pagine dell'applicazione.        Questo layout definisce la struttura comune delle pagine dell'applicazione, che include il menu di navigazione e un'area per il contenuto specifico della pagina. Tutte le pagine che utilizzano questo layout       avranno la stessa struttura, ma con contenuti diversi. Questa pagina non è visuallizzabile in quanto è solo un contenitore per la struttura base delle pagine che verranno visualizzate.
    * parte superiore:
         •	@using MudBlazor importa il namespace MudBlazor, che è una libreria di componenti per Blazor.
       
         •	@inherits LayoutComponentBase indica che questo componente eredita da LayoutComponentBase, che è la classe base per i layout in Blazor.

        ![Screenshot 2024-04-10 120257](https://github.com/Mich120201/Blog/assets/97882894/6e2de22a-2a20-4a3c-b257-8aac2fa7a4aa)

         •	Il blocco <style> contiene i CSS per la formattazione del layout.

       ![Screenshot 2024-04-10 120308](https://github.com/Mich120201/Blog/assets/97882894/70d39a5a-dbce-4e08-8ecd-15c602df4864)

    * Nel corpo del layout, c'è un div con la classe "page" che contiene il menu di navigazione e il contenuto principale dell'applicazione.
         •	NavMenu è un componente che viene utilizzato per visualizzare il menu di navigazione. Questo componente viene visualizzato in tutte le pagine che utilizzano questo layout.
       
         •	Il tag <main> contiene un <article> con la classe "content" e un padding di 4 unità. Questo è dove il contenuto specifico di ogni pagina viene visualizzato.
       
         •	@Body è un segnaposto che viene sostituito con il contenuto specifico di ogni pagina.

       ![Screenshot 2024-04-10 120316](https://github.com/Mich120201/Blog/assets/97882894/41e01ed2-26e3-4d33-82b6-75c3de144cfe)

  * Pagina "NavMenu"
    Questa è la definizione del menu di navigazione per un'applicazione Blazor. Il menu di navigazione è un componente speciale che viene utilizzato per navigare tra le diverse pagine dell'applicazione. Questo        componente definisce il menu di navigazione dell'applicazione, che include link alla homepage, alla pagina "About Me" e alla pagina "New Post". Quando l'utente clicca su uno di questi link, l'applicazione         naviga alla pagina corrispondente.
    * parte superiore:
         •	@using importa vari namespace necessari per il codice.
       
         •	@inject NavigationManager NavManager e @inject IJSRuntime JSRuntime iniettano un'istanza di NavigationManager e IJSRuntime che possono essere utilizzate per la navigazione e l'esecuzione di codice                 JavaScript, rispettivamente.

        ![Screenshot 2024-04-10 120713](https://github.com/Mich120201/Blog/assets/97882894/aabb301a-99d8-4f36-bd12-beaf654f201c)

         •	Il blocco <style> contiene i CSS per la formattazione del menu di navigazione.

        ![Screenshot 2024-04-10 120721](https://github.com/Mich120201/Blog/assets/97882894/7ff56537-769a-41bc-961b-1dedfcad5e9c)


    * Nel corpo del componente, c'è un elemento <nav> che contiene tre div: "nav-left", "nav-center" e "nav-right":
         •	"nav-left" contiene un elemento <text> che visualizza il titolo "Storie di Coda".
       
         •	"nav-center" contiene due link, "Home" e "Chi Sono", che portano rispettivamente alla homepage e alla pagina "About Me".
       
         •	"nav-right" contiene un link a "/newpost" con un pulsante "Nuovo Post".

       ![Screenshot 2024-04-10 120729](https://github.com/Mich120201/Blog/assets/97882894/4d8ff671-ba74-419d-aed1-c4a94e7dab54)
