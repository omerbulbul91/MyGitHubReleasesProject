# Program.cs

Bu örnekte, GitHub'ın REST API'sini kullanarak, belirli bir GitHub deposunun (repository) son release'ini sorgulayan basit bir C# konsol uygulaması geliştireceğiz. GitHub API'si, bu tür bilgilere erişim sağlamak için sık kullanılan ve iyi dokümante edilmiş bir REST API'dir.

Aşağıda, `HttpClient` sınıfını kullanarak GitHub API'sine GET isteği gönderen ve sonucu JSON olarak ekrana yazdıran basit bir C# programı bulunmaktadır. Bu örnekte, `Newtonsoft.Json` kütüphanesini kullanarak JSON yanıtını işleyeceğiz, bu yüzden projenize bu kütüphaneyi eklemeniz gerekecektir. Bu kütüphaneyi NuGet Package Manager aracılığıyla projenize ekleyebilirsiniz: `Install-Package Newtonsoft.Json`

{% @github-files/github-code-block url="https://github.com/omerbulbul91/MyGitHubReleasesProject/blob/main/Program.cs" %}

Bu kod parçası, belirli bir GitHub deposunun (bu örnekte, .NET Runtime'ın) son release bilgilerini sorgular ve bu bilgileri konsolda gösterir. Programı çalıştırmadan önce, projenizin `Newtonsoft.Json` paketini içerdiğinden emin olun.

Bu temel örnek, REST API'lerle çalışmanın basit bir yolunu gösterir. Gerçek dünya senaryolarında, API yanıtlarını işlemek ve istemci tarafında uygun hata yönetimi yapmak için daha fazla kod yazmanız gerekebilir.
