import { Osepaishvili_Halyk_TaskTemplatePage } from './app.po';

describe('Osepaishvili_Halyk_Task App', function() {
  let page: Osepaishvili_Halyk_TaskTemplatePage;

  beforeEach(() => {
    page = new Osepaishvili_Halyk_TaskTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
