#### <div align="right">[TR](#design-patterns-tr)</div>
# <div align="center"> Design Patterns</div>

Design patterns refer to reusable solutions to common problems that occur during software design and development. These patterns have been identified and documented by experts in the field of software development and are intended to help developers create robust and maintainable software systems.

Design patterns are typically used to solve common problems that occur during the development process, such as object creation, object relationships, algorithm design, and communication between objects. By using these patterns, developers can save time and effort by reusing proven solutions rather than creating new ones from scratch.

Overall, design patterns can help developers create more efficient, maintainable, and scalable software systems, by providing proven solutions to common problems encountered in the development process.

## Structural Patterns

Structural patterns are a category of design patterns that are concerned with the composition of classes and objects. These patterns are used to create relationships between different objects, allowing them to work together in a coordinated and efficient manner.

Structural patterns typically involve the use of inheritance and composition to create complex object structures. They are used to solve problems related to object composition, such as how to create object hierarchies, how to create complex objects from simpler ones, and how to make objects work together to achieve a common goal.
> [Adapter Pattern](#adapter-pattern) <br/>
> Bridge Pattern <br/>
> Filter Pattern <br/>
> Composite Pattern <br/>
> [Decorator Pattern](#decorator-pattern) <br/>
> Facade Pattern <br/>
> Flweight Patter <br/>
> [Proxy Pattern](#proxy-pattern) <br/>

## Behavioral Patterns

Behavioral patterns are design patterns that deal with the behavior and communication between objects. They focus on the interactions between objects and how they operate together to achieve a certain goal.

Overall, behavioral patterns are useful for creating flexible and maintainable systems by separating the behavior and responsibilities of objects, and allowing them to interact in a clear and understandable way.

> Chain of Responsibility <br/>
> Command Pattern <br/>
> Iterator Pattern <br/>
> Mediator  Pattern <br/>
> Memento Pattern <br/>
> [Observer Pattern](#observer-pattern) <br/>
> State Pattern <br/>
> [Strategy Pattern](#strategy-pattern) <br/>
> Visitor Pattern <br/>

## Creational Patterns

Creational patterns are a type of design pattern that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. They provide a way to create objects while hiding the creation logic, making the code more flexible and easier to maintain.

Overall, creational patterns are useful for creating flexible and maintainable systems by separating the responsibilities of object creation from the rest of the code, and providing a clear and consistent way to create new objects.

> [Singleton Pattern](#singleton-pattern) <br/>
> Factory Method Pattern <br/>
> Iterator Pattern <br/>
> Abstract Factory Pattern <br/>
> [Builder Pattern](#builder-pattern) <br/>
> Prototype Pattern <br/>

### <a name="adapter-pattern"></a> Adapter Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/AdapterDesignPattern">code example</a>

The Adapter pattern is a structural design pattern that allows incompatible objects to collaborate. It acts as a bridge between two incompatible interfaces, allowing them to work together without the need to modify their source code.

The Adapter pattern is particularly useful when you need to integrate an existing class into a new system or when you want to use an existing class that doesn't have the interface you need.

The pattern involves creating a new adapter class that implements the required interface and adapts the methods of the incompatible class to the new interface. The adapter class acts as a translator, converting the method calls from the new system into calls that the incompatible class can understand.

### <a name="singleton-pattern"></a> Singleton Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/SingletonDesignPattern">code example</a>

Singleton pattern is a creational design pattern that ensures a class has only one instance, while providing a global point of access to this instance. This means that there is a single instance of the class, and all clients that need to use the class will use this same instance. The purpose of the Singleton pattern is to control object creation, limiting the number of instances to one and providing a way to access that instance globally.

This pattern is useful when we need to ensure that there is only one instance of a class throughout the lifetime of an application. Examples of this could include a logging service, a database connection, or a configuration manager. In these cases, having multiple instances of the class could cause issues such as conflicting data, performance problems, or increased memory usage.

To implement the Singleton pattern, we typically use a private constructor to prevent direct instantiation of the class, a private static variable to hold the single instance of the class, and a public static method to provide access to this instance. The public static method checks if an instance already exists and returns it if it does, or creates a new instance if it does not. This ensures that only one instance of the class exists and is used throughout the application.

### <a name="strategy-pattern"></a> Strategy Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/StrategyDesignPattern">code example</a>

The strategy pattern is a behavioral design pattern that enables the selection of an algorithm at runtime from a family of related algorithms. It allows clients to choose the algorithm that best suits their needs and to switch between them easily. The strategy pattern is particularly useful when there are several interchangeable variations of an algorithm, which can be encapsulated in a set of classes implementing a common interface.

In summary, the strategy pattern provides a flexible and dynamic way to encapsulate algorithm behavior, making it easier to maintain and extend code over time.

### <a name="builder-pattern"></a> Builder Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/BuilderDesignPattern">code example</a>

The Builder pattern is a creational design pattern that allows you to create complex objects step by step. It separates the construction of an object from its representation, making it easier to create and customize different representations of the same object.

### <a name="observer-pattern"></a> Observer Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/ObserverDesignPattern">code example</a>

Observer design pattern is a behavioral pattern that defines a one-to-many dependency between objects, where a change in one object (the subject) will notify all of its dependents (observers) and update them automatically. The observer pattern is used when we need to maintain consistency between related objects without tightly coupling them.

### <a name="proxy-pattern"></a> Proxy Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/ProxyDesignPattern">code example</a>

Proxy design pattern is a structural pattern that allows for an object to act as a stand-in or placeholder for another object. This can be useful in situations where creating the real object is resource-intensive or where it's necessary to control access to the real object. The Proxy pattern provides a way to create a surrogate for an object and allows for additional functionality to be provided before or after the real object operation.

### <a name="decorator-pattern"></a> Decorator Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/DecoratorDesignPattern">code example</a>

The Decorator design pattern is a structural pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. It is a flexible alternative to subclassing, as it provides a way to add or remove behaviors at runtime, rather than at compile time.

The Decorator pattern involves a set of decorator classes that are used to wrap concrete components. These decorators add functionality to the component without changing the component's interface. In other words, they "decorate" the component with additional behavior or functionality.

# <a name="design-patterns-tr"></a> <div align="center"> Tasarım Desenleri</div>

Tasarım kalıpları, yazılım tasarımı ve geliştirme sırasında ortaya çıkan yaygın sorunlara yönelik tekrar kullanılabilir çözümleri ifade eder. Bu kalıplar, yazılım geliştirme alanında uzman kişiler tarafından tanımlanmış ve belgelenmiştir ve geliştiricilerin sağlam ve bakımı kolay yazılım sistemleri oluşturmalarına yardımcı olmak için tasarlanmıştır.

Tasarım kalıpları genellikle nesne oluşturma, nesne ilişkileri, algoritma tasarımı ve nesneler arası iletişim gibi geliştirme sürecinde karşılaşılan yaygın sorunları çözmek için kullanılır. Bu kalıpları kullanarak, geliştiriciler yeni çözümler oluşturmak yerine kanıtlanmış çözümleri tekrar kullanarak zaman ve çaba tasarrufu yapabilirler.

Genel olarak, tasarım kalıpları, geliştirme sürecinde karşılaşılan yaygın sorunlara kanıtlanmış çözümler sağlayarak, geliştiricilerin daha verimli, bakımı kolay ve ölçeklenebilir yazılım sistemleri oluşturmalarına yardımcı olabilir.

## Yapısal Kalıplar

Yapısal kalıplar, sınıfların ve nesnelerin bileşimleri ile ilgili olan tasarım kalıplarının bir kategorisidir. Bu kalıplar, farklı nesneler arasında ilişkiler oluşturarak, onların koordineli ve etkili bir şekilde birlikte çalışmasını sağlar.

Yapısal kalıplar genellikle, karmaşık nesne yapıları oluşturmak için miras ve bileşim kullanımını içerir. Nesne bileşimi ile ilgili problemleri çözmek için kullanılırlar, örneğin nesne hiyerarşileri nasıl oluşturulur, daha basit nesnelerden karmaşık nesneler nasıl oluşturulur ve nesnelerin ortak bir hedefe ulaşmak için birlikte nasıl çalışacakları gibi konular.

> [Adapter Pattern](#adapter-pattern-tr) <br/>
> Bridge Pattern <br/>
> Filter Pattern <br/>
> Composite Pattern <br/>
> [Decorator Pattern](#decorator-pattern-tr) <br/>
> Facade Pattern <br/>
> Flweight Patter <br/>
> [Proxy Pattern](#proxy-pattern-tr) <br/>

## Davranışsal Kalıplar  

Davranışsal kalıplar, nesneler arasındaki davranış ve iletişimle ilgili olan tasarım kalıplarıdır. Nesneler arasındaki etkileşimlere ve bir hedefe ulaşmak için birlikte nasıl çalıştıklarına odaklanırlar.

Genel olarak, davranışsal kalıplar, nesnelerin davranış ve sorumluluklarını ayırarak esnek ve bakımı kolay sistemler oluşturmak için yararlıdır ve nesnelerin net ve anlaşılır bir şekilde etkileşime girmelerine izin verirler.

> Chain of Responsibility <br/>
> Command Pattern <br/>
> Iterator Pattern <br/>
> Mediator  Pattern <br/>
> Memento Pattern <br/>
> [Observer Pattern](#observer-pattern-tr) <br/>
> State Pattern <br/>
> [Strategy Pattern](#strategy-pattern-tr) <br/>
> Visitor Pattern <br/>

## Yaratımsal Kalıplar

Yaratımsal kalıplar, nesne oluşturma mekanizmalarıyla ilgili tasarım kalıplarının bir türüdür ve nesneleri duruma uygun bir şekilde oluşturmaya çalışırlar. Nesne oluşturma mantığını gizleyerek nesne oluştur

Genel olarak, yaratımsal kalıplar, nesne oluşturma sorumluluğunu kodun geri kalanından ayırarak esnek ve bakımı kolay sistemler oluşturmak için yararlıdır ve yeni nesneler oluşturmak için net ve tutarlı bir yol sağlarlar.

> [Singleton Pattern](#singleton-pattern-tr) <br/>
> Factory Method Pattern <br/>
> Iterator Pattern <br/>
> Abstract Factory Pattern <br/>
> [Builder Pattern](#builder-pattern-tr) <br/>
> Prototype Pattern <br/>

### <a name="adapter-pattern-tr"></a> Adapter Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/AdapterDesignPattern">code example</a>

Adaptör tasarım deseni, uyumsuz nesnelerin birlikte çalışmasına izin veren bir yapısal tasarım desenidir. İki uyumsuz arayüz arasında bir köprü görevi görerek, kaynak kodlarını değiştirmeden birlikte çalışmalarını sağlar.

Adaptör tasarım deseni özellikle, mevcut bir sınıfı yeni bir sisteme entegre etmeniz veya ihtiyacınız olan arayüze sahip olmayan bir mevcut sınıfı kullanmak istediğinizde faydalıdır.

Bu desen, gereken arayüzü uygulayan ve uyumsuz sınıfın yöntemlerini yeni arayüze adapte eden bir adaptör sınıfı oluşturmayı içerir. Adaptör sınıfı bir çevirmen olarak işlev görerek, yeni sistemden gelen yöntem çağrılarını, uyumsuz sınıfın anlayabileceği çağrılara dönüştürür.

### <a name="singleton-pattern-tr"></a> Singleton Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/SingletonDesignPattern">code example</a>

Tek nesne tasarım deseni, bir sınıfın yalnızca bir örneği olduğunu ve bu örneğe küresel bir erişim noktası sağlarken, sınıfın sadece bir örneğinin olmasını sağlayan bir yaratımsal tasarım desenidir. Bu, sınıfın yalnızca bir örneği olduğu ve sınıfı kullanmak isteyen tüm istemcilerin bu aynı örneği kullanacağı anlamına gelir. Tek Nesne tasarım deseninin amacı, nesne oluşturmayı kontrol etmek, örnekleme sayısını birleştirmek ve bu örneğe küresel erişim sağlamaktır.

Bu desen, bir uygulamanın yaşam döngüsü boyunca bir sınıfın yalnızca bir örneğinin olmasını sağlamamız gerektiğinde kullanışlıdır. Bu örnekler arasında bir günlük hizmeti, bir veritabanı bağlantısı veya bir yapılandırma yöneticisi yer alabilir. Bu durumlarda, sınıfın birden fazla örneği, çakışan veri, performans sorunları veya artan bellek kullanımı gibi sorunlara neden olabilir.

Tek Nesne tasarım desenini uygulamak için genellikle, sınıfın doğrudan örnekleme yapılmasını önlemek için özel bir yapıcı kullanırız. Tek bir örneği tutmak için özel bir statik değişken kullanırız ve bu örneğe erişim sağlamak için genellikle bir genel statik yöntem kullanırız. Genel statik yöntemi, bir örneğin zaten var olup olmadığını kontrol eder ve varsa onu döndürür veya yoksa yeni bir örnek oluşturur.

### <a name="strategy-pattern-tr"></a> Strategy Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/StrategyDesignPattern">code example</a>

Strateji deseni, ilgili bir grup algoritma arasından çalışma zamanında bir algoritma seçmeyi mümkün kılan bir davranışsal tasarım desenidir. Müşterilere ihtiyaçlarına en uygun algoritmayı seçme ve kolayca değiştirme imkanı sunar. Strateji deseni özellikle bir algoritmanın birden fazla değiştirilebilir varyasyonu olduğunda faydalıdır ve ortak bir arayüzü uygulayan bir sınıf kümesiyle kapsüllenebilir.

Özetle, strateji deseni, algoritma davranışlarını esnek ve dinamik bir şekilde kapsüle ederek, kodu zaman içinde daha kolay bakım ve genişletmeye uygun hale getirir.

### <a name="builder-pattern-tr"></a> Builder-Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/BuilderDesignPattern">code example</a>

Oluşturucu deseni, adım adım karmaşık nesneler oluşturmanıza olanak tanıyan bir yaratımsal tasarım desenidir. Nesnenin yapısını temsilinden ayrıştırır ve aynı nesnenin farklı temsillerini oluşturmayı ve özelleştirmeyi kolaylaştırır.

### <a name="observer-pattern-tr"></a> Observer Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/ObserverDesignPattern">code example</a>

Gözlemci deseni, bir nesne (konu) değiştiğinde, bağımlıları (gözlemciler) arasında bir-çok ilişki tanımlayan bir davranışsal desendir. Gözlemci deseni, bağımlılık olan ilgili nesneler arasındaki tutarlılığı sıkı bir şekilde bağlamadan korumamız gerektiğinde kullanılır.

### <a name="proxy-pattern-tr"></a> Proxy Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/ProxyDesignPattern">code example</a>

Proxy (vekil) tasarım deseni, bir nesnenin yerine geçen veya yerine geçen bir nesne olarak hareket etmesine izin veren yapısal bir tasarım desenidir. Gerçek nesneyi oluşturmak kaynak yoğun olduğunda veya gerçek nesneye erişimi kontrol etmek gerektiğinde faydalı olabilir. Proxy deseni, bir nesnenin yerine geçen bir yer tutucu oluşturmanın ve gerçek nesne işleminden önce veya sonra ek işlevler sağlamanın bir yolunu sağlar.

### <a name="decorator-pattern-tr"></a> Decorator Pattern
#### <a href="https://github.com/halisuyanik/Design-Patterns/tree/master/DecoratorDesignPattern">code example</a>

Decorator (süsleyici) tasarım deseni, bir bireysel nesneye, aynı sınıftan diğer nesnelerin davranışını etkilemeden, statik veya dinamik olarak davranış eklenmesine izin veren bir yapısal tasarım desenidir. Alt sınıflama yerine esnek bir alternatif sağlar, çünkü çalışma zamanında davranışları eklemek veya kaldırmak için bir yol sağlar.

Decorator deseni, somut bileşenleri saran bir dizi dekoratör sınıfını içerir. Bu dekoratörler, bileşene arayüzünü değiştirmeden işlevsellik ekler. Başka bir deyişle, bileşeni ek işlev veya davranışla "süsleyebilirler".
