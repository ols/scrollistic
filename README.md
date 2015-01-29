# scrollistic
Using <a href="https://angularjs.org/">angularjs</a> combined with <a href="https://github.com/sroze/ngInfiniteScroll">ngInfiniteScroll</a> to fetch data with flow. First injecting 128 objects from server into angular arraylist scope which is displayed with a ng-repeat using angular filter unique which prevent any duplicates to be added to the view. Also using <a href="https://github.com/Pasvaz/bindonce">bindonce</a> to prevent watchers, ng-repeat combined with <a href="https://github.com/Pasvaz/bindonce">bindonce</a> is very effective. But to get even better performance <a href="https://github.com/kamilkp/angular-vs-repeat">vs-repeat</a> is used along to let the user think that all elements is rendered and all needed to do is to scroll. But we're actually only rendering as many elements that can fit into the current container. But that's not all we're also lazy loading images using <a href="https://github.com/afklm/ng-lazy-image">afkl-lazy-image</a> which is only fetching the images that's visible to the user.