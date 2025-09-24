import { ErwaaSystemTemplatePage } from './app.po';

describe('ErwaaSystem App', function () {
    let page: ErwaaSystemTemplatePage;

    beforeEach(() => {
        page = new ErwaaSystemTemplatePage();
    });

    it('should display message saying app works', () => {
        page.navigateTo();
        expect(page.getParagraphText()).toEqual('app works!');
    });
});
